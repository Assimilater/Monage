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
    public partial class TicketList : UserControl {
        private Transaction Transaction;
        private TransactionFrame ParentFrame;
        public TicketList() { InitializeComponent(); }
        public void Set(Transaction transaction, TransactionFrame parent = null) {
            if (parent == null) {
                // Shrink the control appropriately if we're not in edit mode
                this.Width -= 61;
            }

            this.ParentFrame = parent;
            this.Transaction = transaction;
            this.getUpdate();
        }

        public void getUpdate() {
            pnlTickets.Controls.Clear();
            IEnumerable<Ticket> tickets = this.Transaction.Tickets;

            int cnt = 0;
            TicketMaster tm = null;
            foreach (Ticket ticket in tickets.OrderByDescending(x => x.Amount)) {
                tm = new TicketMaster(ticket, this.ParentFrame);
                tm.Location = new Point(tm.Margin.Left, (tm.Size.Height - 1) * cnt++);

                // Set the background color
                bool valid = true;
                try { ticket.Validate(); } catch { valid = false; }
                tm.BackColor = !valid
                    ? Color.MistyRose : (cnt % 2 == 0
                    ? Color.WhiteSmoke
                    : Color.White);

                pnlTickets.Controls.Add(tm);
            }
        }
    }
}
