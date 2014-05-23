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
    public partial class Banks : DockedFrame, Frame {
        public Banks() {
            InitializeComponent();
        }
        public string TitleAppend() { return "Manage Banks"; }
        public bool Ready(string con, string conf) { return Program.ConfirmClose(con, conf); }
    }
}
