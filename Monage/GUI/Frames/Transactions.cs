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
    public partial class Transactions : DockedFrame, Frame {
        public Transactions() {
            InitializeComponent();
        }
        public string TitleAppend() { return "New Transaction"; }
        public bool Ready(string con, string conf) { return Program.ConfirmClose(con, conf); }
    }
}
