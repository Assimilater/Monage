using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monage.GUI.Frames {
    public interface IFrame {
        IFrame Set(Shell connection, Panel canvas);
        IFrame Adjust();
        
        string Title();
        bool Ready(string conf);
    }

    //public abstract class CenteredFrame : UserControl, IFrame {
    public class CenteredFrame : UserControl, IFrame {
        public Shell Connection { get; private set; }
        protected Panel Canvas { get; private set; }

        public virtual IFrame Set(Shell connection, Panel canvas) {
            Connection = connection;
            Canvas = canvas;

            Canvas.Controls.Clear();
            Canvas.Controls.Add(this);
            Adjust();
            return this;
        }
        public virtual IFrame Adjust() {
            this.Location = new Point(
                Canvas.Width / 2 - (this.Width / 2),
                Canvas.Height / 2 - (this.Height / 2)
            );
            return this;
        }

        // Methods to pass on to derrived classes
        //public abstract string TitleAppend();
        //public abstract bool Ready(string conf);
        public virtual string Title() { return ""; }
        public virtual bool Ready(string conf) { return true; }
    }

    //public abstract class DockedFrame : UserControl, IFrame {
    public class DockedFrame : UserControl, IFrame {
        public Shell Connection { get; private set; }
        protected Panel Canvas { get; private set; }

        public DockedFrame() {
            this.AutoScroll = true;
        }

        public virtual IFrame Set(Shell connection, Panel canvas) {
            Connection = connection;
            Canvas = canvas;

            canvas.Controls.Clear();
            canvas.Controls.Add(this);
            this.Dock = DockStyle.Fill;
            return this;
        }

        public virtual IFrame Adjust() {
            // No need to do anything here
            return this;
        }

        // Methods to pass on to derrived classes
        //public abstract string TitleAppend();
        //public abstract bool Ready(string conf);
        public virtual string Title() { return ""; }
        public virtual bool Ready(string conf) { return true; }
    }
}
