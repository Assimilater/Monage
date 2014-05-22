using Monage.GUI.Dialogs;
using Monage.GUI.Frames;
using Monage.Models;
using Monage.Utilities;
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

        #region Shell Control-Flow Management
        
        public Shell(string p) {
            InitializeComponent();
            pre = p;
            Login(Program.db.Users.Count() == 1 ? Program.db.Users.First() : null);
        }

        public Shell(Shell copy, Frame view) {
            InitializeComponent();

            pre = Program.Host.AddShell(this);
            user = copy.user;


            view.Set(this, Content);
            UpdateShell();
        }

        private void Content_Resize(object sender, EventArgs e) {
            foreach (Frame c in Content.Controls) { c.Adjust(); }
        }

        #endregion

        #region Window Title, Status Bar, and Context Menu Configuration

        private void UpdateShell() {
            Title();
            LogoutStrip();
        }

        private void Title() {
            this.Text = pre + " - " + (
                user == null
                ? "Login"
                : user.Username
            );
        }

        private void LogoutStrip() {
            logoutToolStripMenuItem.Visible = user != null;
            toolStripSeparator1.Visible = user != null;
        }

        #endregion

        #region Action and Frame Events

        public void Login(User u) {
            user = u;
            if (user == null) {
                new Users().Set(this, Content);
            } else {
                new Session().Set(this, Content);
            }
            UpdateShell();
        }

        #endregion

        #region MenuBar Event Handlers

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e) {
            Login(null);
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e) {
            this.Close();
        }

        #endregion
    }
}
