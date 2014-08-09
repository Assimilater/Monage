using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Monage.Models;
using Monage.GUI.Dialogs;

namespace Monage.GUI.Frames {
    public partial class UsersFrame : Frame {
        public UsersFrame() : base(Position.Centered) { InitializeComponent(); }
        public override string Title() { return "Login"; }
        public override void Ready() { this.getList(); }

        private void getList() {
            int prev = cbxUsers.SelectedIndex;
            cbxUsers.Items.Clear();
            Session.Refresh();
            foreach (User user in Session.db.Users) {
                cbxUsers.Items.Add(user.Username);
            }

            cbxUsers.SelectedIndex =
                prev == -1 && cbxUsers.Items.Count > 0 ? 0 : prev;
        }

        private void btnOpen_Click(object sender, EventArgs e) {
            if (cbxUsers.SelectedIndex != -1) {
                Program.Window.Login(Session.Login((string)cbxUsers.SelectedItem));
            } else {
                MessageBox.Show(Program.Window, "No user selected");
            }
        }

        private void btnNew_Click(object sender, EventArgs e) { getUsername(new User()); }
        private void btnRename_Click(object sender, EventArgs e) {
            if (cbxUsers.SelectedIndex != -1) {
                getUsername(Session.db.Users.Where(x => x.Username == (string)cbxUsers.SelectedItem).First());
            } else {
                MessageBox.Show(Program.Window, "No user selected");
            }
        }

        private void getUsername(User user) {
            try {
                user.Rename(
                    InputDialog.ShowDialog(
                        "Enter a new Username for: " + user.Username,
                        "Set Username",
                        user.Username
                    )
                );
                getList();
            } catch (ValidationException ex) {
                MessageBox.Show(Program.Window, ex.Message);
            }
        }
    }
}
