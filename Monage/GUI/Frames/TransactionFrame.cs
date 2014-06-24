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
    public partial class TransactionFrame : DockedFrame {
        Transaction Ticket;
        public TransactionFrame(Transaction ticket = null) {
            InitializeComponent();
            Ticket = ticket == null ? new Transaction() : ticket;

            /*
            dtConfirm.ValueChanged += (s, e) =>
                txtDetails.Text =
                    "Is Checked: " + dtConfirm.Checked.ToString() + Environment.NewLine +
                    dtConfirm.Value.ToString();
             */
        }
        public override string Title() { return "New Transaction"; }
        public override bool Ready(string conf) { return Program.ConfirmReady(Connection.ConnectionString, conf); }

        public override IFrame Set(Shell connection, Panel canvas) {
            base.Set(connection, canvas);

            BindingList<KeyValuePair<int, string>> Banks = new BindingList<KeyValuePair<int, string>>();
            foreach (Bank b in Bank.Enumerate(Connection.User)) {
                Banks.Add(new KeyValuePair<int, string>(b.ID, b.Name));
            }

            cbxBanks.DataSource = Banks;
            cbxBanks.ValueMember = "Key";
            cbxBanks.DisplayMember = "Value";

            cbxExpense.Hide();
            return this;
        }

        private void dtConfirm_ValueChanged(object sender, EventArgs e) {

        }

        private void dtRecord_ValueChanged(object sender, EventArgs e) {

        }

        private void txtDetails_TextChanged(object sender, EventArgs e) {

        }

        private void cbxCreditType_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void cbxExpense_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void cbxBanks_SelectedIndexChanged(object sender, EventArgs e) {

        }
    }
}
