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

namespace Monage.GUI.Controls {
    public partial class TicketMaster : UserControl {
        private Ticket Ticket;
        private TransactionFrame ParentFrame;
        private void btnDelete_Click(object sender, EventArgs e) { ParentFrame.RemoveTicket(this.Ticket); }

        public TicketMaster() { InitializeComponent(); }
        public TicketMaster(TransactionFrame parentframe, Ticket ticket) {
            InitializeComponent();
            this.ParentFrame = parentframe;
            this.Ticket = ticket;

            try {
                this.Ticket.Validate();
            } catch {
                this.BackColor = Color.MistyRose;
            }

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
    }
}
