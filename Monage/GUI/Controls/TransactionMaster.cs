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
    public partial class TransactionMaster : UserControl {
        public class Filters {
            public Bank Bank { get; set; }
            public Bucket Bucket { get; set; }
            public Filters(Bank bank) { this.Bank = bank; this.Bucket = null; }
            public Filters(Bucket bucket) { this.Bank = null; this.Bucket = bucket; }
            public Filters(Bank bank, Bucket bucket) { this.Bank = bank; this.Bucket = bucket; }
        }

        private bool _Expanded;
        public bool Expanded {
            get { return this._Expanded; }
            set {
                this._Expanded = value;
                this.Height = value ? 475 : 34;
                this.btnExpand.Image = value
                    ? Properties.Resources.IconMinus
                    : Properties.Resources.IconPlus;

                this.ParentFrame.AdjustList();
            }
        }

        private double Total;
        private int TransactionID;
        private TicketList TicketList;
        private HistoryFrame ParentFrame;

        private void init() {
            this._Expanded = false;
            this.Height = 34;
            this.btnExpand.Image = Properties.Resources.IconPlus;
        }
        public TransactionMaster() { InitializeComponent(); this.init(); }
        public TransactionMaster(Transaction transaction, HistoryFrame parentframe) {
            InitializeComponent();
            this.init();

            this.ParentFrame = parentframe;
            this.TransactionID = transaction.ID;
            lblDetails.Text = transaction.Details;
            lblBrief.Text = transaction.Brief;
            lblIncurred.Text = transaction.Incurred.ToString("MM/dd/yyyy");
            lblConfirmed.Text = transaction.Confirmed == null
                ? "Never" : transaction.Confirmed.Value.ToString("MM/dd/yyyy");

            this.TicketList = new TicketList(transaction);
            this.TicketList.Location = new Point(6, 189);
            pnlExpanded.Controls.Add(this.TicketList);

            lblAmount.Text = (this.Total = transaction.Tickets
                .Where(x => x.Amount > 0)
                .Sum(x => x.Amount))
                .ToString("C");
        }

        private void btnExpand_Click(object sender, EventArgs e) { this.Expanded = !this.Expanded; }
        private void btnEdit_Click(object sender, EventArgs e) {

        }
    }
}
