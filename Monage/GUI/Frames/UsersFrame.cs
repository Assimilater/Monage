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
        public UsersFrame() : base(FramePosition.Centered) { InitializeComponent(); }
        public override string Title() { return "Login"; }
        public override bool Ready(string conf) { return true; }
        public override Frame Set(Shell connection, Panel canvas) {
            base.Set(connection, canvas);
            getList();
            return this;
        }
        
        private void getList() {
            int prev = cbxUsers.SelectedIndex;
            cbxUsers.Items.Clear();
            foreach (User u in Program.db.Users) {
                cbxUsers.Items.Add(u.Username);
            }

            cbxUsers.SelectedIndex =
                prev == -1 && cbxUsers.Items.Count > 0 ? 0 : prev;
        }

        private void btnOpen_Click(object sender, EventArgs e) {
            if (cbxUsers.SelectedIndex != -1) {
                Connection.Login(Program.db.Users.Where(x => x.Username == (string)cbxUsers.SelectedItem).First());
            } else {
                MessageBox.Show(Program.Host, "No user selected");
            }
        }

        private void btnNew_Click(object sender, EventArgs e) { getUsername(new User()); }
        private void btnRename_Click(object sender, EventArgs e) {
            if (cbxUsers.SelectedIndex != -1) {
                getUsername(Program.db.Users.Where(x => x.Username == (string)cbxUsers.SelectedItem).First());
            } else {
                MessageBox.Show(Program.Host, "No user selected");
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
                MessageBox.Show(Program.Host, ex.Message);
            }
        }
    }
}
