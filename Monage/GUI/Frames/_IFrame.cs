using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monage.GUI.Frames {
    public interface IFrame {
        IFrame Clone();
        IFrame Set(Shell p, Panel c);
        IFrame Adjust();
        
        string TitleAppend();
        bool Ready(string con, string conf);
    }

    //public abstract class CenteredFrame : UserControl, IFrame {
    public class CenteredFrame : UserControl, IFrame {
        protected Shell parent;
        protected Panel canvas;

        public virtual IFrame Set(Shell p, Panel c) {
            parent = p;
            canvas = c;

            canvas.Controls.Clear();
            canvas.Controls.Add(this);
            Adjust();
            return this;
        }
        public virtual IFrame Adjust() {
            this.Location = new Point(
                canvas.Width / 2 - (this.Width / 2),
                canvas.Height / 2 - (this.Height / 2)
            );
            return this;
        }

        // Methods to pass on to derrived classes
        //public abstract string TitleAppend();
        //public abstract bool Ready(string con, string conf);
        //public abstract IFrame Clone();
        public virtual string TitleAppend() { return ""; }
        public virtual bool Ready(string con, string conf) { return true; }
        public virtual IFrame Clone() { return new CenteredFrame(); }
    }

    //public abstract class DockedFrame : UserControl, IFrame {
    public class DockedFrame : UserControl, IFrame {
        protected Shell parent;
        protected Panel canvas;

        public DockedFrame() {
            this.AutoScroll = true;
        }

        public virtual IFrame Set(Shell p, Panel c) {
            parent = p;
            canvas = c;

            canvas.Controls.Clear();
            canvas.Controls.Add(this);
            this.Dock = DockStyle.Fill;
            return this;
        }

        public virtual IFrame Adjust() {
            // No need to do anything
            return this;
        }

        // Methods to pass on to derrived classes
        //public abstract string TitleAppend();
        //public abstract bool Ready(string con, string conf);
        //public abstract IFrame Clone();
        public virtual string TitleAppend() { return ""; }
        public virtual bool Ready(string con, string conf) { return true; }
        public virtual IFrame Clone() { return new DockedFrame(); }
    }
}
