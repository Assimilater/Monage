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
        private string pre;
        private User user;
        private IFrame active;

        #region Shell Control-Flow Management
        
        public Shell(string p) {
            InitializeComponent();

            pre = p;
            Login(
                Program.db.Users.Count() == 1
                ? Program.db.Users.First()
                : null
            );
        }

        public Shell(Shell copy, IFrame view) {
            InitializeComponent();

            pre = Program.Host.AddShell(this);
            user = copy.user;
            SetFrame(view);
        }

        public bool Ready(string conf = "Navigation") {
            return
                active != null
                ? active.Ready(pre, conf)
                : true;
        }

        private void SetFrame(IFrame view, string conf = "Navigation") {
            if (Ready(conf)) {
                active = view;
                active.Set(this, Content);
            }
            UpdateShell();
        }

        private void Content_Resize(object sender, EventArgs e) {
            foreach (IFrame c in Content.Controls) { c.Adjust(); }
        }

        private void UpdateShell() {
            UpdateTitle();
            UpdateMenuBar();
        }

        public void UpdateTitle() {
            this.Text = pre + (
                user == null
                ? ""
                : " - " + (
                    user.Username + (
                        active != null
                        ? ": " + active.TitleAppend()
                        : ""
                    )
                )
            );
        }

        private void UpdateMenuBar() {
            summaryToolStripMenuItem.Visible = 
            newTransactionToolStripMenuItem.Visible =
            historyToolStripMenuItem.Visible =

            toolStripSeparator1.Visible =
            
            banksToolStripMenuItem.Visible =
            bucketsToolStripMenuItem.Visible =
            budgetsToolStripMenuItem.Visible =
            
            toolStripSeparator2.Visible =
                        
            logoutToolStripMenuItem.Visible =

                user != null;
        }

        #endregion

        #region MenuBar Event Handlers
        
        private void summaryToolStripMenuItem_Click(object sender, EventArgs e) {
            if (user != null) {
                SetFrame(new Summary());
            }
        }

        private void newTransactionToolStripMenuItem_Click(object sender, EventArgs e) {
            if (user != null) {
                SetFrame(new Transactions());
            }
        }

        private void historyToolStripMenuItem_Click(object sender, EventArgs e) {
            if (user != null) {
                SetFrame(new History());
            }
        }

        private void banksToolStripMenuItem_Click(object sender, EventArgs e) {
            if (user != null) {
                SetFrame(new Banks());
            }
        }

        private void bucketsToolStripMenuItem_Click(object sender, EventArgs e) {
            if (user != null) {
                SetFrame(new Buckets());
            }
        }

        private void budgetsToolStripMenuItem_Click(object sender, EventArgs e) {
            if (user != null) {
                SetFrame(new Budgets());
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

        public void Login(User u) {
            user = u;

            IFrame view =
                user == null
                ? new Users() as IFrame
                : new Summary() as IFrame;

            SetFrame(view, "Logout");
        }
    }
}
