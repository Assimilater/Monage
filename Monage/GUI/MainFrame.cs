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
    public partial class MainFrame : Form {
        private User user;

        #region MainFrame Control-Flow Management
        
        public MainFrame() {
            InitializeComponent();
            if (Program.db.Users.Count() == 1) {
                Open(Program.db.Users.First());
            } else {
                su();
            }
        }

        private void Content_Resize(object sender, EventArgs e) {
            foreach (Frame c in Content.Controls) { c.Adjust(); }
        }

        private void Title() {
            this.Text = "Monage ~ " + (
                user == null
                ? "Login"
                : user.Username
            );

            if (user == null) { MenuBar.Hide(); } else { MenuBar.Show(); }
        }

        #endregion

        private void su() {
            user = null;
            Title();

            new Users().Set(this, Content);
        }
        public void Open(User u) {
            user = u;
            Title();

            new Session().Set(this, Content);
        }

        #region MenuBar Event Handlers

        private void switchUserToolStripMenuItem_Click(object sender, EventArgs e) { su(); }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e) { this.Close(); }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e) {
            new About().ShowDialog();
        }

        #endregion
    }
}
