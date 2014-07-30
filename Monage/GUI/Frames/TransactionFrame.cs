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

namespace Monage.GUI.Frames {
    public partial class TransactionFrame : Frame {
        Transaction Transaction;
        public TransactionFrame(Transaction transaction = null)
            : base(FramePosition.TopCenter) {
            InitializeComponent();
            Transaction = transaction == null ? new Transaction() : transaction;
        }
        public override string Title() { return "New Transaction"; }
        public override bool Ready(string conf) { return Program.ConfirmReady(Connection.ConnectionString, conf); }

        public override Frame Set(Shell connection, Panel canvas) {
            base.Set(connection, canvas);

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

            return this;
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
    }
}
