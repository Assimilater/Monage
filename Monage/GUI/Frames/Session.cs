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
    public partial class Session : UserControl, Frame {
        MainFrame parent;
        Panel canvas;

        public Session() {
            InitializeComponent();
        }

        public void Set(MainFrame p, Panel c) {
            parent = p;
            canvas = c;

            canvas.Controls.Clear();
            canvas.Controls.Add(this);
            this.Dock = DockStyle.Fill;
        }

        public void Adjust() {
            // No need to do anything
        }
    }
}
