using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Monage.Models;
using System.ComponentModel.DataAnnotations;
using Monage.GUI.Controls;

namespace Monage.GUI.Frames {
    public partial class TransactionFrame : Frame {
        bool Saved;
        Transaction Transaction;

        public TransactionFrame(Transaction transaction = null)
            : base(FramePosition.TopCenter) {
            InitializeComponent();
            cbxAction.SelectedIndex = 0;

            this.Saved = false;
            this.Transaction = transaction == null ? new Transaction() : transaction;

            this.getTicketList();
        }

        public override string Title() { return "New Transaction"; }
        public override bool Ready(string conf) {
            return this.Saved ||
                Program.ConfirmReady(Connection.ConnectionString, conf);
        }
        public override Frame Set(Shell connection, Panel canvas) {
            base.Set(connection, canvas);
            this.getLists();
            return this;
        }
        public override Frame Adjust() {
            base.Adjust();
            this.Height = this.Canvas.Height;
            this.lblTickets.Height = this.Height - 319;
            lblCheck.Location = new Point(361, this.Height - 29);
            lblDebitAmount.Location = new Point(467, this.Height - 32);
            lblCreditAmount.Location = new Point(640, this.Height - 32);
            return this;
        }

        private class TicketResult {
            public TicketResult() { this.Tickets = new List<Ticket>(); }
            public List<Ticket> Tickets { get; set; }
            public string AppendedNotes { get; set; }
        }
        private void btnAddTicket_Click(object sender, EventArgs e) {
            TicketResult tr = new TicketResult();

            switch (cbxAction.SelectedItem.ToString()) {
                case "Apply Budget":
                    if ((tr = this.ApplyBudget(tr)) == null) { return; }
                    break;
                case "Deposit / Withdraw":
                    if ((tr = this.AdjustBank(tr)) == null) { return; }
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
                MessageBox.Show(Program.Host, ex.Message);
                return;
            }

            // Append to the notes section any new information
            txtDetails.Text += Environment.NewLine + tr.AppendedNotes;

            // Add all tickets associated with this action
            foreach (Ticket ticket in tr.Tickets) {
                this.Transaction.Tickets.Add(ticket);
            }

            // Update the ticket list
            this.getTicketList();
        }

        private TicketResult ApplyBudget(TicketResult tr) {
            // separator is 50 '-'s and an EOL
            const string separator = "--------------------------------------------------\r\n";

            // Start by recording the revenue
            tr = this.WriteRevenue(tr);
            if (tr == null) { return null; }

            // Validate the bank/budget selection
            Budget budget = Budget.Enumerate(this.Connection.User)
                .FirstOrDefault(x => x.ID == (int)cbxBudgets.SelectedValue);

            Bank bank = Bank.Enumerate(this.Connection.User)
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
            tr.AppendedNotes += separator
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
                        ticket = new Ticket(this.Connection.User, this.Transaction);
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
                    final = new Ticket(this.Connection.User, this.Transaction);
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
        private TicketResult AdjustBank(TicketResult tr) {
            Ticket ticket = new Ticket(this.Connection.User, this.Transaction);
            ticket.Amount = (double)Math.Round(numAmount.Value, 2);

            ticket.Bank = Bank.Enumerate(this.Connection.User)
                .FirstOrDefault(x => x.ID == (int)cbxBanks.SelectedValue);

            ticket.Bucket = Bucket.Enumerate(this.Connection.User)
                .FirstOrDefault(x => x.ID == (int)cbxBuckets.SelectedValue);

            if (ticket.Bank == null) {
                MessageBox.Show("Error finding selected bank");
                return null;
            }
            if (ticket.Bucket == null) {
                MessageBox.Show("Error finding selected bucket");
                return null;
            }

            tr.Tickets.Add(ticket);
            return tr;
        }
        private TicketResult WriteRevenue(TicketResult tr) {
            Ticket ticket = new Ticket(this.Connection.User, this.Transaction);
            ticket.Amount = (double)Math.Round(-1 * numAmount.Value, 2);
            ticket.Company = txtCompany.Text;
            ticket.Fund = Fund.Enumerate(this.Connection.User, BalanceType.Credit)
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
            Ticket ticket = new Ticket(this.Connection.User, this.Transaction);
            ticket.Amount = (double)Math.Round(numAmount.Value, 2);
            ticket.Company = txtCompany.Text;
            ticket.Fund = Fund.Enumerate(this.Connection.User, BalanceType.Debit)
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

        private void getTicketList() {
            pnlTickets.Controls.Clear();
            IEnumerable<Ticket> tickets = this.Transaction.Tickets;

            int cnt = 0;
            foreach (Ticket ticket in tickets.OrderByDescending(x => x.Amount)) {
                TicketMaster tm = new TicketMaster(this, ticket);
                tm.Location = new Point(
                    tm.Margin.Left,
                    tm.Margin.Top + ((tm.Margin.Top + tm.Size.Height + tm.Margin.Bottom) * cnt++)
                );
                pnlTickets.Controls.Add(tm);
            }

            lblCheck.ForeColor = tickets.Sum(x => x.Amount) == 0 ? Color.Green : Color.Red;
            lblDebitAmount.Text = tickets.Where(x => x.Amount > 0).Sum(x => x.Amount).ToString("C");
            lblCreditAmount.Text = (tickets.Where(x => x.Amount < 0).Sum(x => x.Amount) * -1).ToString("C");
        }
        private void getLists() {
            // Populate the combo boxes with the available accounts
            BindingList<KeyValuePair<int, string>>
                Banks = new BindingList<KeyValuePair<int, string>>(),
                Buckets = new BindingList<KeyValuePair<int, string>>(),
                Budgets = new BindingList<KeyValuePair<int, string>>(),
                Expenses = new BindingList<KeyValuePair<int, string>>(),
                Revenues = new BindingList<KeyValuePair<int, string>>();

            foreach (Bank bank in Bank.Enumerate(Connection.User)) {
                Banks.Add(new KeyValuePair<int, string>(bank.ID, bank.Name));
            }
            foreach (Bucket bucket in Bucket.Enumerate(Connection.User)) {
                Buckets.Add(new KeyValuePair<int, string>(bucket.ID, bucket.Name));
            }
            foreach (Budget budget in Budget.Enumerate(Connection.User)) {
                Budgets.Add(new KeyValuePair<int, string>(budget.ID, budget.Name));
            }
            foreach (Fund expense in Fund.Enumerate(Connection.User, BalanceType.Debit)) {
                Expenses.Add(new KeyValuePair<int, string>(expense.ID, expense.Name));
            }
            foreach (Fund revenue in Fund.Enumerate(Connection.User, BalanceType.Credit)) {
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

            // Prepare an auto complete source for the company field
            txtCompany.AutoCompleteCustomSource = new AutoCompleteStringCollection();
            foreach (IGrouping<string, Ticket> group in
                Program.db.Tickets
                    .Where(x => x.Company != "")
                    .GroupBy(x => x.Company)) {
                txtCompany.AutoCompleteCustomSource.Add(group.Key);
            }
        }

        private void dtConfirm_ValueChanged(object sender, EventArgs e) {
            if (dtConfirm.Checked) {
                this.Transaction.Confirmed = dtConfirm.Value;
            } else {
                this.Transaction.Confirmed = null;
            }
        }
        private void dtRecord_ValueChanged(object sender, EventArgs e) {
            this.Transaction.Incurred = dtRecord.Value;
        }
        private void txtDetails_TextChanged(object sender, EventArgs e) {
            this.Transaction.Details = txtDetails.Text;
        }
        private void txtBrief_TextChanged(object sender, EventArgs e) {
            this.Transaction.Brief = txtBrief.Text;
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

                case "Deposit / Withdraw":
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
                this.Saved = true;
                this.Connection.GoHome();
            } catch (ValidationException ex) {
                MessageBox.Show(Program.Host, ex.Message);
            }
        }

        public void RemoveTicket(Ticket ticket) {
            this.Transaction.Tickets.Remove(ticket);
            this.getTicketList();
        }
    }
}
