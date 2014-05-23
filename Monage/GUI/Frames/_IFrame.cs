using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monage.GUI.Frames {
    public interface Frame {
        void Set(Shell p, Panel c);
        void Adjust();

        string TitleAppend();
        bool Ready(string con, string conf);
    }

    public class CenteredFrame : UserControl {
        protected Shell parent;
        protected Panel canvas;

        public void Set(Shell p, Panel c) {
            parent = p;
            canvas = c;

            canvas.Controls.Clear();
            canvas.Controls.Add(this);
            Adjust();
        }
        public void Adjust() {
            this.Location = new Point(
                canvas.Width / 2 - (this.Width / 2),
                canvas.Height / 2 - (this.Height / 2)
            );
        }
    }

    public class DockedFrame : UserControl {
        protected Shell parent;
        protected Panel canvas;

        public DockedFrame() {
            this.AutoScroll = true;
        }

        public void Set(Shell p, Panel c) {
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
