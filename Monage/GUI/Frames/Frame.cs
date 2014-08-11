using Monage.GUI.Lists;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monage.GUI.Frames {
    [Flags]
    public enum Position {
        // Common Cases
        Docked = 0, Centered = 18,

        // Distinct Flags
        Top = 1, Middle = 2, Bottom = 4,
        Left = 8, Center = 16, Right = 32,

        // Combined Values
        TopLeft = 9, TopCenter = 17, TopRight = 33,
        MiddleLeft = 10, MiddleCenter = 18, MiddleRight = 34,
        BottomLeft = 12, BottomCenter = 20, BottomRight = 36,

        // Other Modifiers
        FullHeight = 64, FullWidth = 128
    }

    public enum State {
        Ready,
        Confirm
    }

    public abstract class Frame : UserControl {
    //public class Frame : UserControl {
        public Position Position { get; protected set; }
        public State State { get; protected set; }

        //public Frame() { this.Position = Position.Docked; this.State = State.Ready; }
        public Frame(Position position = Position.Docked, State state = State.Ready) { 
            this.Position = position;
            this.State = state;
        }

        public virtual Frame Adjust(Panel Canvas) {
            if (this.Position != Position.Docked) {
                this.Dock = DockStyle.None;
                this.Location = new Point(
                    // Horizontal
                    this.Position.HasFlag(Position.Left)
                    ? 0 : (this.Position.HasFlag(Position.Center)
                    ? Canvas.Width / 2 - (this.Width / 2)
                    : Canvas.Width - this.Width),

                    // Vertical
                    this.Position.HasFlag(Position.Top)
                    ? 0 : (this.Position.HasFlag(Position.Middle)
                    ? Canvas.Height / 2 - (this.Height / 2)
                    : Canvas.Height - this.Height)
                );

                if (this.Position.HasFlag(Position.FullHeight)) {
                    this.Height = Canvas.Height;
                }

                if (this.Position.HasFlag(Position.FullWidth)) {
                    this.Width = Canvas.Width;
                }
            } else {
                this.Dock = DockStyle.Fill;
                this.Location = new Point(0, 0);
            }
            return this;
        }

        // Methods to pass on to derrived classes
        public abstract string Title();
        public abstract void Ready();
        //public virtual string Title() { return ""; }
        //public virtual void Ready() { }
    }

    public abstract class SummaryFrame : Frame {
    //public class SummaryFrame : Frame {
        protected Panel ContentPane { get; set; }
        public SummaryFrame() : base(Position.Docked) { }

        private ListPane Pane { get; set; }
        protected ListItem Item { get; set; }
        public void SelectItem(ListItem item) {
            if (this.State != State.Confirm || Program.ConfirmReady("Navigation")) {
                if (this.Item != null) {
                    this.Item.Toggle(false);
                }
                this.Item = item;
                this.Item.Toggle(true);

                this.ContentPane.Controls.Clear();
                this.Pane = this.Item.getPane();
                if (this.Pane != null) {
                    this.ContentPane.Controls.Add(this.Pane);
                }
            }
        }

        // Methods to pass on to derrived classes
        public override abstract string Title();
        public override abstract void Ready();
        //public override string Title() { return ""; }
        //public override void Ready() { }
    }
}
