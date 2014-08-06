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
        private List<TransactionMaster> Transactions;
        public HistoryFrame()
            : base(Position.TopCenter | Position.FullHeight) {
            InitializeComponent();
        }
        public override string Title() { return "Transaction History"; }
        public override void Ready() {
            this.Transactions = new List<TransactionMaster>();
            foreach (Transaction transaction in Session.db.Transactions.OrderBy(x => x.Incurred)) {
                TransactionMaster tm = new TransactionMaster(transaction, this);
                this.Transactions.Add(tm);
                pnlTransactions.Controls.Add(tm);
            }
            this.AdjustList();
        }

        public void AdjustList() {
            int y = 0;
            foreach (TransactionMaster row in this.Transactions) {
                row.Location = new Point(3, y);
                y += row.Height - 1;
            }
        }
    }
}
