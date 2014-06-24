using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monage.GUI.Frames {
    public partial class SummaryFrame : DockedFrame {
        public SummaryFrame() { InitializeComponent(); }
        private ListPane Pane { get; set; }
        public override string TitleAppend() { return "Financial Summary"; }
        public override IFrame Set(Shell connection, Panel canvas) {
            base.Set(connection, canvas);
            banksFrame.Set(this, Connection.User);
            bucketsFrame.Set(this, Connection.User);
            budgetsFrame.Set(this, Connection.User);
            return this;
        }
        public override bool Ready(string con, string conf) {
            return
                this.Pane != null
                ? this.Pane.Ready(con, conf)
                : true;
        }
    }
}
