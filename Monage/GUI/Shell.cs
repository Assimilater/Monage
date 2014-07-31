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

            ConnectionString = con;

            Login(
                (Program.db.Users.Count() == 1 && Settings.ActiveUser == Settings.NullInt)
                ? Program.db.Users.First()
                : Program.db.Users.FirstOrDefault(x => x.ID == Settings.ActiveUser)
            );
        }

        private void cloneConnectionToolStripMenuItem_Click(object sender, EventArgs e) {
            Program.Host.AddShell(new Shell(this, active));
        }

        public Shell(Shell copy, Frame view) {
            InitializeComponent();

            ConnectionString = Program.Host.AddShell(this);
            User = copy.User;
            SetFrame(new SummaryFrame());
        }

        public bool Ready(string conf = "Navigation") {
            return
                active != null
                ? active.Ready(conf)
                : true;
        }

        public Shell GoHome() {
            this.SetFrame(new SummaryFrame());
            return this;
        }

        private void SetFrame(Frame view, string conf = "Navigation") {
            if (Ready(conf)) {
                active = view;
                active.Set(this, Content);
            }
            UpdateShell();
        }

        private void Content_Resize(object sender, EventArgs e) {
            foreach (Frame c in Content.Controls) { c.Adjust(); }
        }

        private void UpdateShell() {
            UpdateTitle();
            UpdateMenuBar();
        }

        public Shell UpdateTitle() {
            this.Text = ConnectionString + (
                User == null
                ? ""
                : " - " + (
                    User.Username + (
                        active != null
                        ? ": " + active.Title()
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

                User != null;
        }

        #endregion

        #region MenuBar Event Handlers
        
        private void summaryToolStripMenuItem_Click(object sender, EventArgs e) {
            if (User != null) {
                SetFrame(new SummaryFrame());
            }
        }

        private void newTransactionToolStripMenuItem_Click(object sender, EventArgs e) {
            if (User != null) {
                SetFrame(new TransactionFrame());
            }
        }

        private void historyToolStripMenuItem_Click(object sender, EventArgs e) {
            if (User != null) {
                SetFrame(new HistoryFrame());
            }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e) {
            Login(null);
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e) {
            if (Ready("Close")) {
                this.Close();
            }
        }

        #endregion

        public Shell Login(User u) {
            User = u;
            Settings.ActiveUser = User == null ? -1 : User.ID;

            Frame view =
                User == null
                ? new UsersFrame() as Frame
                : new SummaryFrame() as Frame;

            SetFrame(view, "Logout");
            return this;
        }
    }
}
