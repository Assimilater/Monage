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
    public partial class TransactionMaster : UserControl {
        private bool _expanded;
        public int CollapseRow(bool expanded) {
            this._expanded = expanded;
            this.btnExpand.Image = expanded
                ? Properties.Resources.IconMinus
                : Properties.Resources.IconPlus;

            int height = expanded ? 475 : 34;
            this.Height = height;
            return height;
        }

        // Keep track of strings to pass on to ConfirmedDialog
        private string
            confirmIncurred = null,
            confirmBrief = null,
            confirmCashflow = null,
            confirmAffecting = null,
            confirmAmount = null,
            confirmBalance = null;

        private int TransactionID;
        private Transaction Transaction;
        private HistoryFrame ParentFrame;
        private TicketList TicketList;

        public TransactionMaster() { InitializeComponent(); }
        public TransactionMaster(Transaction transaction, HistoryFrame parentframe) {
            InitializeComponent();

            this._expanded = false;
            this.ParentFrame = parentframe;
            this.Transaction = transaction;
            this.TransactionID = transaction.ID;
            lblDetails.Text = transaction.Details;
            lblBrief.Text = this.confirmBrief = transaction.Brief;
            lblIncurred.Text = this.confirmIncurred = transaction.Incurred.ToString("MM/dd/yyyy");
            lblConfirmed.Text = transaction.Confirmed == null
                ? "Never" : transaction.Confirmed.Value.ToString("MM/dd/yyyy");

            this.TicketList = new TicketList();
            this.TicketList.Set(transaction);
            this.TicketList.Location = new Point(6, 188);
            pnlExpanded.Controls.Add(this.TicketList);

            if (Settings.FilterBanks == 0 && Settings.FilterBuckets == 0) {
                lblBalance.Text = this.confirmCashflow = transaction.Tickets
                    .Where(x => x.Amount > 0)
                    .Sum(x => x.Amount)
                    .ToString("C");
            } else {
                IEnumerable<Ticket>
                    allTickets = Session.db.Tickets,
                    thisTickets = this.Transaction.Tickets;

                if (Settings.FilterConfirmed) {
                    if (this.Transaction.Confirmed != null) {
                        allTickets = allTickets
                            .Where(x => x.Transaction.Confirmed <= this.Transaction.Confirmed);
                    } else {
                        allTickets = allTickets
                            .Where(x => x.Transaction.Confirmed != null
                                || x.Transaction.Incurred <= this.Transaction.Incurred);
                    }
                } else {
                    allTickets = allTickets
                        .Where(x => x.Transaction.Incurred <= this.Transaction.Incurred);
                }

                if (Settings.FilterBanks != 0) {
                    allTickets = allTickets.Where(x => x.Bank_ID == Settings.FilterBanks);
                    thisTickets = thisTickets.Where(x => x.Bank_ID == Settings.FilterBanks);
                    this.confirmAffecting = Session.db.Banks
                        .First(x => x.ID == Settings.FilterBanks).Name;
                }

                if (Settings.FilterBuckets != 0) {
                    allTickets = allTickets.Where(x => x.Bucket_ID == Settings.FilterBuckets);
                    thisTickets = thisTickets.Where(x => x.Bucket_ID == Settings.FilterBuckets);
                    string bucket = Session.db.Buckets
                        .First(x => x.ID == Settings.FilterBuckets).Name;
                    if (String.IsNullOrEmpty(this.confirmAffecting)) {
                        this.confirmAffecting = bucket;
                    } else {
                        this.confirmAffecting += " [" + bucket + "]";
                    }
                }

                lblAmount.Text = this.confirmAmount = thisTickets.Sum(x => x.Amount).ToString("C");
                lblBalance.Text = this.confirmBalance = allTickets.Sum(x => x.Amount).ToString("C");
            }
        }

        private void btnExpand_Click(object sender, EventArgs e) {
            this.ParentFrame.Accordion(this, !_expanded);
        }
        private void btnEdit_Click(object sender, EventArgs e) {
            Program.Window.SetFrame(new TransactionFrame(this.TransactionID));
        }
        private void btnConfirm_Click(object sender, EventArgs e) {
            DateTime? confirmed =
                this.confirmAffecting == null
                ? ConfirmedDialog.ShowDialog(this.confirmIncurred, this.confirmBrief, this.confirmCashflow)
                : ConfirmedDialog.ShowDialog(this.confirmIncurred, this.confirmBrief, this.confirmAffecting, this.confirmAmount, this.confirmBalance);

            if (confirmed != null) {
                this.Transaction.Confirmed = confirmed;
                this.Transaction.Save();
                Session.Refresh();
                ParentFrame.UpdateFilters();
            }
        }
    }
}
