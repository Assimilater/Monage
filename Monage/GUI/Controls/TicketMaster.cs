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
using Monage.GUI.Frames;
using Monage.GUI.Dialogs;

namespace Monage.GUI.Controls {
    public partial class TicketMaster : UserControl {
        private Ticket Ticket;
        private TransactionFrame ParentFrame;
        public TicketMaster() { InitializeComponent(); }
        public TicketMaster(Ticket ticket, TransactionFrame parent) {
            InitializeComponent();
            if (parent == null) {
                // Shrink the control appropriately if we're not in edit mode
                this.Width -= 61;
                btnAdjust.Hide();
                btnDelete.Hide();
            }

            this.ParentFrame = parent;
            this.Ticket = ticket;
            this.Setup();
        }

        private void Setup() {
            if (this.Ticket.Amount < 0) {
                lblCredit.Text =
                    this.Ticket.Bank != null
                    ? this.Ticket.Bank.Name + " [" + this.Ticket.Bucket.Name + "]"
                    : this.Ticket.Fund.Name + (this.Ticket.Company != "" ? " [" + this.Ticket.Company + "]" : "");

                lblCreditAmount.Text = (this.Ticket.Amount * -1).ToString("C");
            } else {
                lblDebit.Text =
                    this.Ticket.Bank != null
                    ? this.Ticket.Bank.Name + " [" + this.Ticket.Bucket.Name + "]"
                    : this.Ticket.Fund.Name + (this.Ticket.Company != "" ? " [" + this.Ticket.Company + "]" : "");

                lblDebitAmount.Text = this.Ticket.Amount.ToString("C");
                lblCredit.Hide();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            if (this.ParentFrame != null) {
                ParentFrame.RemoveTicket(this.Ticket);
            }
        }

        private void btnAdjust_Click(object sender, EventArgs e) {
            if (this.ParentFrame != null) {
                decimal? amount = AmountDialog.ShowDialog(this.Ticket.Amount);
                if (amount != null) {
                    this.Ticket.Amount = amount.Value;
                    this.ParentFrame.getTicketUpdate();
                }
            }
        }
    }
}
