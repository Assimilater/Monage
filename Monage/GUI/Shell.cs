using Monage.GUI.Dialogs;
using Monage.GUI.Frames;
using Monage.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monage.GUI {
    public partial class Shell : Form {
        public User User { get; private set; }
        public string ConnectionString { get; private set; }
        private Frame active;

        #region Shell Control-Flow Management
        
        public Shell(string con) {
            InitializeComponent();

            this.ConnectionString = con;

            Login(
                (Program.db.Users.Count() == 1 && Settings.ActiveUser == Settings.NullInt)
                ? Program.db.Users.First()
                : Program.db.Users.FirstOrDefault(x => x.ID == Settings.ActiveUser)
            );
        }

        private void cloneConnectionToolStripMenuItem_Click(object sender, EventArgs e) {
            Program.Host.AddShell(new Shell(this, this.active));
        }

        public Shell(Shell copy, Frame view) {
            InitializeComponent();

            this.ConnectionString = Program.Host.AddShell(this);
            this.User = copy.User;
            this.SetFrame(new SummaryFrame());
        }

        public bool Ready(string conf = "Navigation") {
            return
                this.active != null
                ? this.active.Ready(conf)
                : true;
        }

        public Shell GoHome() {
            this.SetFrame(new SummaryFrame());
            return this;
        }

        private void SetFrame(Frame view, string conf = "Navigation") {
            if (this.Ready(conf)) {
                this.active = view;
                this.active.Set(this, Content);
                this.active.Adjust();
            }
            this.UpdateTitle();
            this.UpdateMenuBar();
        }

        private void Content_Resize(object sender, EventArgs e) {
            foreach (Frame c in Content.Controls) { c.Adjust(); }
        }

        public Shell UpdateTitle() {
            this.Text = ConnectionString + (
                this.User == null
                ? ""
                : " - " + (
                    this.User.Username + (
                        this.active != null
                        ? ": " + this.active.Title()
                        : ""
                    )
                )
            );
            return this;
        }

        private void UpdateMenuBar() {
            accountSummaryToolStripMenuItem.Visible = 
            newTransactionToolStripMenuItem.Visible =
            transactionHistoryToolStripMenuItem.Visible =

            toolStripSeparator1.Visible =
            logoutToolStripMenuItem.Visible =

                this.User != null;
        }

        #endregion

        #region MenuBar Event Handlers
        
        private void summaryToolStripMenuItem_Click(object sender, EventArgs e) {
            if (this.User != null) {
                this.SetFrame(new SummaryFrame());
            }
        }

        private void newTransactionToolStripMenuItem_Click(object sender, EventArgs e) {
            if (this.User != null) {
                this.SetFrame(new TransactionFrame());
            }
        }

        private void historyToolStripMenuItem_Click(object sender, EventArgs e) {
            if (this.User != null) {
                this.SetFrame(new HistoryFrame());
            }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e) {
            this.Login(null);
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e) {
            if (this.Ready("Close")) {
                this.Close();
            }
        }

        #endregion

        public Shell Login(User user) {
            this.User = user;
            Settings.ActiveUser = User == null ? -1 : this.User.ID;

            Frame view =
                this.User == null
                ? new UsersFrame() as Frame
                : new SummaryFrame() as Frame;

            this.SetFrame(view, "Logout");
            return this;
        }
    }
}
