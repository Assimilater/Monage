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
    public partial class Summary : DockedFrame {
        public Summary() {
            InitializeComponent();
        }
        public override string TitleAppend() { return "Financial Summary"; }
        public override bool Ready(string con, string conf) { return true; }
    }
}
