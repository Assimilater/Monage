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
    public partial class Users : CenteredFrame {
        public Users() { InitializeComponent(); }
        public override IFrame Clone() { return new Users(); }
        public override string TitleAppend() { return "Login"; }
        public override bool Ready(string con, string conf) { return true; }
        public override IFrame Set(Shell p, Panel c) {
            base.Set(p, c);
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
                parent.Login(Program.db.Users.Where(x => x.Username == (string)cbxUsers.SelectedItem).First());
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
            } catch (ValidationException e) {
                MessageBox.Show(Program.Host, e.Message);
            }
        }
    }
}
