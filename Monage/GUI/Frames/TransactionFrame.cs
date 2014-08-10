using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Monage.Models;
using Monage.GUI.Controls;

namespace Monage.GUI.Frames {
    public partial class TransactionFrame : Frame {
        private Transaction Transaction;
        private TicketList TicketList;
        private int TransactionID;
        private string FrameTitle;
        private bool ReadyState;

        public TransactionFrame(int TransactionID = 0)
            : base(Position.TopCenter | Position.FullHeight, State.Confirm) {
            InitializeComponent();
            cbxAction.SelectedIndex = 0;

            this.ReadyState = false;

            this.TransactionID = TransactionID;
        }

        public override string Title() { return this.FrameTitle; }
        public override void Ready() {
            this.Transaction =
                Session.db.Transactions
                    .FirstOrDefault(x =>
                        x.ID == this.TransactionID &&
                        x.User_ID == Session.User.ID)
                ?? new Transaction(Session.User);

            this.FrameTitle =
                this.Transaction.ID == 0
                    ? "New Transaction"
                    : "Update Transaction";

            txtBrief.Text = this.Transaction.Brief;
            txtDetails.Text = this.Transaction.Details;
            dtIncur.Value = this.Transaction.Incurred;
            dtConfirm.Value = this.Transaction.Confirmed != null
                ? this.Transaction.Confirmed.Value
                : DateTime.Now;
            dtConfirm.Checked = this.Transaction.Confirmed != null;

            // Add a live view of the tickets
            this.TicketList = new TicketList(this.Transaction, this);
            this.TicketList.Location = new Point(3, 284);
            this.Controls.Add(this.TicketList);

            this.getTicketUpdate();
            this.getLists();
            this.ReadyState = true;
        }
        public override Frame Adjust(Panel Canvas) {
            base.Adjust(Canvas);
            if (this.TicketList != null) {
                this.TicketList.Height = this.Height - 319;
            }
            return this;
        }

        private class TicketResult {
            public List<Ticket> Tickets { get; set; }
            public string AppendedNotes { get; set; }
            public TicketResult() {
                this.Tickets = new List<Ticket>();
                this.AppendedNotes = "";
            }
        }
        private void btnAddTicket_Click(object sender, EventArgs e) {
            TicketResult tr = new TicketResult();

            switch (cbxAction.SelectedItem.ToString()) {
                case "Apply Budget":
                    if ((tr = this.ApplyBudget(tr)) == null) { return; }
                    break;
                case "Deposit Revenue":
                    if ((tr = this.AdjustBank(tr, 1)) == null) { return; }
                    if ((tr = this.WriteRevenue(tr)) == null) { return; }
                    break;
                case "Withdraw Expense":
                    if ((tr = this.AdjustBank(tr, -1)) == null) { return; }
                    if ((tr = this.WriteExpense(tr)) == null) { return; }
                    break;
                case "Make Deposit":
                    if ((tr = this.AdjustBank(tr, 1)) == null) { return; }
                    break;
                case "Make Withdrawal":
                    if ((tr = this.AdjustBank(tr, -1)) == null) { return; }
                    break;
                case "Write Revenue":
                    if ((tr = this.WriteRevenue(tr)) == null) { return; }
                    break;
                case "Write Expense":
                    if ((tr = this.WriteExpense(tr)) == null) { return; }
                    break;
                default:
                    MessageBox.Show("Unrecognized action");
                    return;
            }

            // Make sure everything validates
            try {
                foreach (Ticket ticket in tr.Tickets) { ticket.Validate(); }
            } catch (ValidationException ex) {
                MessageBox.Show(Program.Window, ex.Message);
                return;
            }

            // Append to the notes section any new information
            txtDetails.Text += tr.AppendedNotes;

            // Add all tickets associated with this action
            foreach (Ticket ticket in tr.Tickets) {
                Ticket existing = this.Transaction.Tickets
                    .FirstOrDefault(x =>
                        x.Bank_ID == ticket.Bank_ID &&
                        x.Bucket_ID == ticket.Bucket_ID &&
                        x.Fund_ID == ticket.Fund_ID &&
                        x.Company == ticket.Company);
                if (existing == null) {
                    this.Transaction.Tickets.Add(ticket);
                } else {
                    existing.Amount += ticket.Amount;
                    if (existing.Amount == 0) {
                        this.Transaction.Tickets.Remove(existing);
                    }
                }
            }

            // Update the ticket list
            this.getTicketUpdate();
        }

        private TicketResult ApplyBudget(TicketResult tr) {
            // separator is 50 '-'s and an EOL
            const string separator = "--------------------------------------------------\r\n";

            // Start by recording the revenue
            tr = this.WriteRevenue(tr);
            if (tr == null) { return null; }

            // Validate the bank/budget selection
            Budget budget = Budget.Enumerate()
                .FirstOrDefault(x => x.ID == (int)cbxBudgets.SelectedValue);

            Bank bank = Bank.Enumerate()
                .FirstOrDefault(x => x.ID == (int)cbxBanks.SelectedValue);

            if (budget == null) {
                MessageBox.Show("Error finding selected budget");
                return null;
            }
            if (bank == null) {
                MessageBox.Show("Error finding selected bank");
                return null;
            }

            // Initialize money trackers
            double Amount = (double)Math.Round(numAmount.Value, 2);
            double subAmount, subTotal;

            // Apply the budget
            tr.AppendedNotes += Environment.NewLine + separator
                + "Applying budget: " + budget.Name + Environment.NewLine;

            List<Ticket> staged = new List<Ticket>();
            foreach (Tier tier in budget.Tiers.OrderBy(x => x.Order)) {
                tr.AppendedNotes += separator
                    + "New tier: beginning amount: " + Amount.ToString("C") + Environment.NewLine
                    + Environment.NewLine;

                subTotal = Amount;
                foreach (Step step in tier.Steps.OrderBy(x => x.Order)) {
                    Ticket ticket = staged.FirstOrDefault(x => x.Bucket == step.Bucket);
                    if (ticket == null) {
                        ticket = new Ticket(Session.User, this.Transaction);
                        ticket.Bank = bank;
                        ticket.Bucket = step.Bucket;
                    }

                    if (tier.Type == TierClass.Ratio) {
                        subAmount = Math.Round(Amount * step.Value, 2);
                        tr.AppendedNotes +=
                            "Add ratio: " + step.Value.ToString("P") + " (" + subAmount.ToString("C") + ")"
                                 + " to " + step.Bucket.Name + Environment.NewLine;
                    } else {
                        if (subTotal - step.Value < 0) {
                            subAmount = subTotal;
                            tr.AppendedNotes += "Add remainder: " + step.Value.ToString("C")
                                + " to " + step.Bucket.Name + Environment.NewLine
                                + "Unable to allocate " + (step.Value - subAmount).ToString("C")
                                + " to " + step.Bucket.Name + Environment.NewLine;
                        } else if (subTotal > 0) {
                            subAmount = step.Value;
                            tr.AppendedNotes += "Add amount: " + step.Value.ToString("C")
                                + " to " + step.Bucket.Name + Environment.NewLine;
                        } else {
                            subAmount = 0;
                            tr.AppendedNotes += "Unable to allocate " + (step.Value - subAmount).ToString("C")
                                + " to " + step.Bucket.Name + Environment.NewLine;
                        }
                    }

                    ticket.Amount += subAmount;
                    subTotal -= subAmount;
                }

                // Updating the amount after this loop prevents inaccuracy in a ratio tier
                Amount = subTotal;
            }

            // Finish remaining amount
            if (Amount != 0) {
                Ticket final = staged.FirstOrDefault(x => x.Bucket == budget.Final);
                if (final == null) {
                    final = new Ticket(Session.User, this.Transaction);
                    final.Bank = bank;
                    final.Bucket = budget.Final;
                }
                final.Amount += Amount;
                tr.AppendedNotes += separator
                    + "Add offset: " + Amount.ToString("C") + " to " + final.Bucket.Name + Environment.NewLine;
            }

            // Add tickets with a zero-balance to the TicketResult
            foreach (Ticket ticket in staged) {
                if (ticket.Amount != 0) {
                    tr.Tickets.Add(ticket);
                }
            }

            return tr;
        }
        private TicketResult AdjustBank(TicketResult tr, int sign) {
            Ticket ticket = new Ticket(Session.User, this.Transaction);
            ticket.Amount = (double)Math.Round(numAmount.Value * sign, 2);

            ticket.Bank = Bank.Enumerate()
                .FirstOrDefault(x => x.ID == (int)cbxBanks.SelectedValue);

            ticket.Bucket = Bucket.Enumerate()
                .FirstOrDefault(x => x.ID == (int)cbxBuckets.SelectedValue);

            if (ticket.Bank == null) {
                MessageBox.Show("Error finding selected bank");
                return null;
            } else {
                ticket.Bank_ID = ticket.Bank.ID;
            }
            if (ticket.Bucket == null) {
                MessageBox.Show("Error finding selected bucket");
                return null;
            } else {
                ticket.Bucket_ID = ticket.Bucket.ID;
            }

            tr.Tickets.Add(ticket);
            return tr;
        }
        private TicketResult WriteRevenue(TicketResult tr) {
            Ticket ticket = new Ticket(Session.User, this.Transaction);
            ticket.Amount = (double)Math.Round(-1 * numAmount.Value, 2);
            ticket.Company = txtCompany.Text;
            ticket.Fund = Fund.Enumerate(BalanceType.Credit)
                .FirstOrDefault(x => x.ID == (int)cbxRevenues.SelectedValue);

            if (ticket.Amount >= 0) {
                MessageBox.Show("Enter a positive dollar amount");
                return null;
            }
            if (ticket.Fund == null) {
                MessageBox.Show("Error finding selected revenue");
                return null;
            }
            if (txtCompany.Text == "") {
                MessageBox.Show("Enter a company name");
                return null;
            }

            tr.Tickets.Add(ticket);
            return tr;
        }
        private TicketResult WriteExpense(TicketResult tr) {
            Ticket ticket = new Ticket(Session.User, this.Transaction);
            ticket.Amount = (double)Math.Round(numAmount.Value, 2);
            ticket.Company = txtCompany.Text;
            ticket.Fund = Fund.Enumerate(BalanceType.Debit)
                .FirstOrDefault(x => x.ID == (int)cbxExpenses.SelectedValue);

            if (ticket.Amount <= 0) {
                MessageBox.Show("Enter a positive dollar amount");
                return null;
            }
            if (ticket.Fund == null) {
                MessageBox.Show("Error finding selected expense");
                return null;
            }
            if (txtCompany.Text == "") {
                MessageBox.Show("Enter a company name");
                return null;
            }

            tr.Tickets.Add(ticket);
            return tr;
        }

        private void getTicketUpdate() {
            IEnumerable<Ticket> tickets = this.Transaction.Tickets;
            pnlCheck.BackColor = tickets.Sum(x => x.Amount) == 0 ? Color.Honeydew : Color.MistyRose;
            lblDebitAmount.Text = tickets.Where(x => x.Amount > 0).Sum(x => x.Amount).ToString("C");
            lblCreditAmount.Text = (tickets.Where(x => x.Amount < 0).Sum(x => x.Amount) * -1).ToString("C");

            this.TicketList.getUpdate();
        }
        private void getLists() {
            // Populate the combo boxes with the available accounts
            BindingList<KeyValuePair<int, string>>
                Banks = new BindingList<KeyValuePair<int, string>>(),
                Buckets = new BindingList<KeyValuePair<int, string>>(),
                Budgets = new BindingList<KeyValuePair<int, string>>(),
                Expenses = new BindingList<KeyValuePair<int, string>>(),
                Revenues = new BindingList<KeyValuePair<int, string>>();

            foreach (Bank bank in Bank.Enumerate()) {
                Banks.Add(new KeyValuePair<int, string>(bank.ID, bank.Name));
            }
            foreach (Bucket bucket in Bucket.Enumerate()) {
                Buckets.Add(new KeyValuePair<int, string>(bucket.ID, bucket.Name));
            }
            foreach (Budget budget in Budget.Enumerate()) {
                Budgets.Add(new KeyValuePair<int, string>(budget.ID, budget.Name));
            }
            foreach (Fund expense in Fund.Enumerate(BalanceType.Debit)) {
                Expenses.Add(new KeyValuePair<int, string>(expense.ID, expense.Name));
            }
            foreach (Fund revenue in Fund.Enumerate(BalanceType.Credit)) {
                Revenues.Add(new KeyValuePair<int, string>(revenue.ID, revenue.Name));
            }

            cbxBanks.DataSource = Banks;
            cbxBanks.ValueMember = "Key";
            cbxBanks.DisplayMember = "Value";

            cbxBuckets.DataSource = Buckets;
            cbxBuckets.ValueMember = "Key";
            cbxBuckets.DisplayMember = "Value";

            cbxBudgets.DataSource = Budgets;
            cbxBudgets.ValueMember = "Key";
            cbxBudgets.DisplayMember = "Value";

            cbxExpenses.DataSource = Expenses;
            cbxExpenses.ValueMember = "Key";
            cbxExpenses.DisplayMember = "Value";

            cbxRevenues.DataSource = Revenues;
            cbxRevenues.ValueMember = "Key";
            cbxRevenues.DisplayMember = "Value";

            // Prepare an auto complete source for the brief and company fields
            AutoCompleteStringCollection
                briefs = new AutoCompleteStringCollection(),
                companies = new AutoCompleteStringCollection();

            foreach (IGrouping<string, Transaction> group in
                Session.db.Transactions
                    .Where(x => x.Brief != "")
                    .GroupBy(x => x.Brief)) {
                if (group.Key != null) { briefs.Add(group.Key); }
            }
            foreach (IGrouping<string, Ticket> group in
                Session.db.Tickets
                    .Where(x => x.Company != "")
                    .GroupBy(x => x.Company)) {
                if (group.Key != null) { companies.Add(group.Key); }
            }

            txtBrief.AutoCompleteCustomSource = briefs;
            txtCompany.AutoCompleteCustomSource = companies;
        }

        private void dtConfirm_ValueChanged(object sender, EventArgs e) {
            if (this.ReadyState) {
                if (dtConfirm.Checked) {
                    this.Transaction.Confirmed = dtConfirm.Value;
                } else {
                    this.Transaction.Confirmed = null;
                }
            }
        }
        private void dtIncur_ValueChanged(object sender, EventArgs e) {
            if (this.ReadyState) { this.Transaction.Incurred = dtIncur.Value; }
        }
        private void txtDetails_TextChanged(object sender, EventArgs e) {
            if (this.ReadyState) { this.Transaction.Details = txtDetails.Text; }
        }
        private void txtBrief_TextChanged(object sender, EventArgs e) {
            if (this.ReadyState) { this.Transaction.Brief = txtBrief.Text; }
        }
        private void cbxAction_SelectedIndexChanged(object sender, EventArgs e) {
            switch (cbxAction.SelectedItem.ToString()) {
                case "Apply Budget":
                    cbxBanks.Enabled = true;
                    cbxBuckets.Enabled = false;
                    cbxBudgets.Enabled = true;
                    cbxRevenues.Enabled = true;
                    cbxExpenses.Enabled = false;
                    txtCompany.Enabled = true;
                    break;

                case "Deposit Revenue":
                    cbxBanks.Enabled = true;
                    cbxBuckets.Enabled = true;
                    cbxBudgets.Enabled = false;
                    cbxRevenues.Enabled = true;
                    cbxExpenses.Enabled = false;
                    txtCompany.Enabled = true;
                    break;

                case "Withdraw Expense":
                    cbxBanks.Enabled = true;
                    cbxBuckets.Enabled = true;
                    cbxBudgets.Enabled = false;
                    cbxRevenues.Enabled = false;
                    cbxExpenses.Enabled = true;
                    txtCompany.Enabled = true;
                    break;

                case "Make Deposit": case "Make Withdrawal":
                    cbxBanks.Enabled = true;
                    cbxBuckets.Enabled = true;
                    cbxBudgets.Enabled = false;
                    cbxRevenues.Enabled = false;
                    cbxExpenses.Enabled = false;
                    txtCompany.Enabled = false;
                    break;

                case "Write Revenue":
                    cbxBanks.Enabled = false;
                    cbxBuckets.Enabled = false;
                    cbxBudgets.Enabled = false;
                    cbxRevenues.Enabled = true;
                    cbxExpenses.Enabled = false;
                    txtCompany.Enabled = true;
                    break;

                case "Write Expense":
                    cbxBanks.Enabled = false;
                    cbxBuckets.Enabled = false;
                    cbxBudgets.Enabled = false;
                    cbxRevenues.Enabled = false;
                    cbxExpenses.Enabled = true;
                    txtCompany.Enabled = true;
                    break;

                default:
                    MessageBox.Show("Unrecognized action");
                    return;
            }
        }
        private void btnSave_Click(object sender, EventArgs e) {
            try {
                this.Transaction.Save();

                // If successful go back to the summary page
                this.State = Frames.State.Ready;
                Program.Window.SetFrame(new SummaryFrame());
            } catch (ValidationException ex) {
                MessageBox.Show(Program.Window, ex.Message);
            }
        }

        public void RemoveTicket(Ticket ticket) {
            if (ticket.ID != 0) {
                Session.db.Tickets.Remove(ticket);
            }
            this.Transaction.Tickets.Remove(ticket);
            this.getTicketUpdate();
        }
    }
}
