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
    public partial class Buckets : DockedFrame {
        public Buckets() {
            InitializeComponent();
        }
        public override string TitleAppend() { return "Manage Buckets"; }
        public override bool Ready(string con, string conf) { return Program.ConfirmReady(con, conf); }
    }
}
