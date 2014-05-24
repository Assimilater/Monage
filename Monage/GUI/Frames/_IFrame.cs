using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monage.GUI.Frames {
    public interface IFrame {
        void Set(Shell p, Panel c);
        void Adjust();

        string TitleAppend();
        bool Ready(string con, string conf);
    }

    public abstract class CenteredFrame : UserControl, IFrame {
        protected Shell parent;
        protected Panel canvas;

        public virtual void Set(Shell p, Panel c) {
            parent = p;
            canvas = c;

            canvas.Controls.Clear();
            canvas.Controls.Add(this);
            Adjust();
        }
        public virtual void Adjust() {
            this.Location = new Point(
                canvas.Width / 2 - (this.Width / 2),
                canvas.Height / 2 - (this.Height / 2)
            );
        }

        // Methods to pass on to derrived classes
        public abstract string TitleAppend();
        public abstract bool Ready(string con, string conf);
    }

    public abstract class DockedFrame : UserControl, IFrame {
        protected Shell parent;
        protected Panel canvas;

        public DockedFrame() {
            this.AutoScroll = true;
        }

        public virtual void Set(Shell p, Panel c) {
            parent = p;
            canvas = c;

            canvas.Controls.Clear();
            canvas.Controls.Add(this);
            this.Dock = DockStyle.Fill;
        }

        public virtual void Adjust() {
            // No need to do anything
        }

        // Methods to pass on to derrived classes
        public abstract string TitleAppend();
        public abstract bool Ready(string con, string conf);
    }
}
