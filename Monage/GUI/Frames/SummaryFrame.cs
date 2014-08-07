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
using Monage.Models;

namespace Monage.GUI.Frames {
    public partial class SummaryFrame : Frame {
        public SummaryFrame()
            : base(Position.Docked) {
            InitializeComponent();
            splitContainer.SplitterDistance = Settings.SplitterDistance;

            banksFrame.Set(this);
            bucketsFrame.Set(this);
            budgetsFrame.Set(this);
            revenueFrame.Set(this);
            expenseFrame.Set(this);
        }
        public override string Title() { return "Financial Summary"; }

        private ListPane Pane { get; set; }
        protected ListItem Item { get; set; }
        public void SelectItem(ListItem item) {
            /*
            if (this.Ready("Navigation")) {
                if (this.Item != null) {
                    this.Item.Toggle(false);
                }
                this.Item = item;
                this.Item.Toggle(true);

                splitContainer.Panel2.Controls.Clear();
                this.Pane = this.Item.getPane();
                if (this.Pane != null) {
                    splitContainer.Panel2.Controls.Add(this.Pane);
                }
            }
            */
        }
        public override void Ready() {

        }

        private void splitContainer_SplitterMoved(object sender, SplitterEventArgs e) {
            Settings.SplitterDistance = splitContainer.SplitterDistance;
        }
    }
}
