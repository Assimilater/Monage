using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Monage.GUI.Controls;
using Monage.Models;

namespace Monage.GUI.Frames {
    public partial class HistoryFrame : Frame {
        private bool watch;
        private List<TransactionMaster> Transactions;
        public HistoryFrame()
            : base(Position.TopCenter | Position.FullHeight) {
            this.watch = false;
            InitializeComponent();
            this.GetLists();
        }
        public override string Title() { return "Transaction History"; }
        public override void Ready() {
            cbxBanks.SelectedValue = Settings.FilterBanks;
            cbxBuckets.SelectedValue = Settings.FilterBuckets;
            if (Settings.FilterConfirmed) {
                rdbConfirmed.Checked = true;
            } else {
                rdbIncurred.Checked = true;
            }
            this.watch = true;
            this.UpdateFilters(null, null);
        }

        public void AdjustList() {
            int y = 0;
            foreach (TransactionMaster row in this.Transactions) {
                row.Location = new Point(3, y);
                y += row.Height - 1;
            }
        }

        private void GetLists() {
            // Populate the combo boxes with the available accounts
            BindingList<KeyValuePair<int, string>>
                Banks = new BindingList<KeyValuePair<int, string>>(),
                Buckets = new BindingList<KeyValuePair<int, string>>();

            Banks.Add(new KeyValuePair<int, string>(0, " --- Show All Banks --- "));
            Buckets.Add(new KeyValuePair<int, string>(0, " --- Show All Buckets --- "));

            foreach (Bank bank in Bank.Enumerate()) {
                Banks.Add(new KeyValuePair<int, string>(bank.ID, bank.Name));
            }
            foreach (Bucket bucket in Bucket.Enumerate()) {
                Buckets.Add(new KeyValuePair<int, string>(bucket.ID, bucket.Name));
            }

            cbxBanks.DataSource = Banks;
            cbxBanks.ValueMember = "Key";
            cbxBanks.DisplayMember = "Value";

            cbxBuckets.DataSource = Buckets;
            cbxBuckets.ValueMember = "Key";
            cbxBuckets.DisplayMember = "Value";
        }

        private void UpdateFilters(object sender, EventArgs e) {
            if (!this.watch) { return; }
            pnlTransactions.Controls.Clear();
            Settings.FilterBanks = (int)cbxBanks.SelectedValue;
            Settings.FilterBuckets = (int)cbxBuckets.SelectedValue;
            IEnumerable<Transaction> transactions = Session.db.Transactions;

            if (rdbConfirmed.Checked) {
                transactions = transactions
                    .OrderByDescending(x => x.Confirmed);
                Settings.FilterConfirmed = true;
            } else {
                transactions = transactions
                    .OrderByDescending(x => x.Incurred);
                Settings.FilterConfirmed = false;
            }

            if (Settings.FilterBanks != 0) {
                transactions = transactions
                    .Where(x => x.Tickets
                        .Where(y => y.Bank_ID == Settings.FilterBanks).Count() > 0);
            }

            if (Settings.FilterBuckets != 0) {
                transactions = transactions
                    .Where(x => x.Tickets
                        .Where(y => y.Bucket_ID == Settings.FilterBuckets).Count() > 0);
            }

            this.Transactions = new List<TransactionMaster>();
            foreach (Transaction transaction in transactions) {
                TransactionMaster tm = new TransactionMaster(transaction, this);
                this.Transactions.Add(tm);
                pnlTransactions.Controls.Add(tm);
            }
            this.AdjustList();
        }
    }
}
