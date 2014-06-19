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
    public partial class Transactions : DockedFrame {
        public Transactions() {
            InitializeComponent();
        }
        public override IFrame Clone() { return new Transactions(); }
        public override string TitleAppend() { return "New Transaction"; }
        public override bool Ready(string con, string conf) { return Program.ConfirmReady(con, conf); }
    }
}
