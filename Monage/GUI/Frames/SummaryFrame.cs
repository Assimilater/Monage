using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Monage.GUI.Lists;

namespace Monage.GUI.Frames {
    public partial class SummaryFrame : Frame {
        public SummaryFrame() : base(FramePosition.Docked) { InitializeComponent(); }
        public override string Title() { return "Financial Summary"; }
        public override Frame Set(Shell connection, Panel canvas) {
            base.Set(connection, canvas);
            banksFrame.Set(this, Connection.User);
            bucketsFrame.Set(this, Connection.User);
            budgetsFrame.Set(this, Connection.User);
            revenueFrame.Set(this, Connection.User);
            expenseFrame.Set(this, Connection.User);
            return this;
        }

        private ListPane Pane { get; set; }
        protected ListItem Item { get; set; }
        public void SelectItem(ListItem item) {
            if (this.Ready("Navigation")) {
                if (this.Item != null) {
                    this.Item.Toggle(false);
                }
                this.Item = item;
                this.Item.Toggle(true);

                splitContainer.Panel2.Controls.Clear();
                this.Pane = this.Item.getPane(this.Connection);
                if (this.Pane != null) {
                    splitContainer.Panel2.Controls.Add(this.Pane);
                }
            }
        }
        public override bool Ready(string conf) {
            return
                this.Pane != null
                ? this.Pane.Ready(conf)
                : true;
        }
    }
}
