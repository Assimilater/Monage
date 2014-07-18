using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monage.GUI.Frames {
    [Flags]
    public enum FramePosition {
        // Common Cases
        Docked = 0, Centered = 18,

        // Distinct Flags
        Top = 1, Middle = 2, Bottom = 4,
        Left = 8, Center = 16, Right = 32,

        // Combined Values
        TopLeft = 9, TopCenter = 17, TopRight = 33,
        MiddleLeft = 10, MiddleCenter = 18, MiddleRight = 34,
        BottomLeft = 12, BottomCenter = 20, BottomRight = 36
    }

    public abstract class Frame : UserControl {
    //public class Frame : UserControl {
        public FramePosition Position { get; private set; }
        public Shell Connection { get; private set; }
        public Panel Canvas { get; private set; }

        //public Frame() { this.Position = FramePosition.Docked; }
        public Frame(FramePosition position) { this.Position = position; }

        public virtual Frame Set(Shell connection, Panel canvas) {
            Connection = connection;
            Canvas = canvas;

            Canvas.Controls.Clear();
            Canvas.Controls.Add(this);
            Adjust();
            return this;
        }
        public virtual Frame Adjust() {
            if (this.Position != FramePosition.Docked) {
                this.Dock = DockStyle.None;
                this.Location = new Point(
                    // Horizontal
                    this.Position.HasFlag(FramePosition.Left)
                    ? 0 : (this.Position.HasFlag(FramePosition.Center)
                    ? Canvas.Width / 2 - (this.Width / 2)
                    : Canvas.Width - this.Width),

                    // Vertical
                    this.Position.HasFlag(FramePosition.Top)
                    ? 0 : (this.Position.HasFlag(FramePosition.Middle)
                    ? Canvas.Height / 2 - (this.Height / 2)
                    : Canvas.Height - this.Height)
                );
            } else {
                this.Dock = DockStyle.Fill;
                this.Location = new Point(0, 0);
            }
            return this;
        }

        // Methods to pass on to derrived classes
        public abstract string Title();
        public abstract bool Ready(string conf);
        //public virtual string Title() { return ""; }
        //public virtual bool Ready(string conf) { return true; }
    }
}
