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
    public partial class HistoryFrame : Frame {
        public HistoryFrame() : base(FramePosition.Docked) {
            InitializeComponent();
        }
        public override string Title() { return "Transaction History"; }
        public override bool Ready(string conf) { return true; }
    }
}
