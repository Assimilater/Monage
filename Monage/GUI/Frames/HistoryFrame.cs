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
        public HistoryFrame() : base(FramePosition.TopCenter) { InitializeComponent(); }
        public override string Title() { return "Transaction History"; }
        public override bool Ready(string conf) { return true; }
        public override Frame Set(Shell connection, Panel canvas) {
            base.Set(connection, canvas);

            this.Transactions = new List<TransactionMaster>();
            using (Context db = new Context()) {
                foreach (Transaction transaction in db.Transactions.OrderBy(x => x.Incurred)) {
                    TransactionMaster tm = new TransactionMaster(transaction, this);
                    this.Transactions.Add(tm);
                    pnlTransactions.Controls.Add(tm);
                }
            }
            this.AdjustList();

            return this;
        }
        public override Frame Adjust() {
            base.Adjust();
            this.Height = this.Canvas.Height;
            return this;
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
