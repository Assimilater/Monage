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
    public partial class History : DockedFrame, Frame {
        public History() {
            InitializeComponent();
        }
        public string TitleAppend() { return "Transaction History"; }
        public bool Ready(string con, string conf) { return Program.ConfirmClose(con, conf); }
    }
}
