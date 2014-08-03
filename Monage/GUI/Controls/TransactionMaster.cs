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

namespace Monage.GUI.Controls {
    public partial class TransactionMaster : UserControl {
        private Transaction Transaction;
        public TransactionMaster() { InitializeComponent(); this.getBankList(); }
        public TransactionMaster(Transaction transaction) {
            InitializeComponent();
            this.getBankList();

            this.Transaction = transaction;
            lblBrief.Text = this.Transaction.Brief;
            lblIncurred.Text = this.Transaction.Incurred.ToString();
            lblConfirmed.Text = this.Transaction.Confirmed == null
                ? "Never" : this.Transaction.Confirmed.Value.ToString();

            lblTotal.Text = this.Transaction.Tickets
                .Where(x => x.Amount > 0)
                .Sum(x => x.Amount)
                .ToString("C");
        }

        private void getBankList() {

        }

        private void btnEdit_Click(object sender, EventArgs e) {

        }

        private void cbxBanks_SelectedIndexChanged(object sender, EventArgs e) {

        }
    }
}
