using Monage.GUI.Dialogs;
using Monage.Models;
using Monage.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monage.GUI.Dialogs {
    public partial class UserDialog : Form {
        private bool endOk;
        private MainFrame parent;
        private UserDialog(MainFrame p) {
            parent = p;
            InitializeComponent();
            endOk = false;
            getList();
            lbxUsers.Focus();
        }

        public static int? SelectUser(MainFrame p) {
            UserDialog i = new UserDialog(p);
            if (i.ShowDialog(p) == DialogResult.OK) {
                return Program.db.Users.Where(
                    x => x.Username == (string)i.lbxUsers.SelectedItem
                ).First().ID;
            } else {
                return null;
            }
        }

        private void UserDialog_FormClosing(object sender, FormClosingEventArgs e) {
            this.DialogResult = endOk ? DialogResult.OK : DialogResult.Cancel;
        }

        private void getList() {
            int prev = lbxUsers.SelectedIndex;
            lbxUsers.Items.Clear();
            foreach (User u in Program.db.Users) {
                lbxUsers.Items.Add(u.Username);
            }

            lbxUsers.SelectedIndex =
                prev == -1 && lbxUsers.Items.Count > 0
                ? 0 : prev;
        }

        private void lbxUsers_DoubleClick(object sender, EventArgs e) { Open(); }
        private void btnOpen_Click(object sender, EventArgs e) { Open(); }
        private void btnNew_Click(object sender, EventArgs e) { New(); }
        private void btnRename_Click(object sender, EventArgs e) { Rename(); }

        private void Open() {
            if (lbxUsers.SelectedIndex != -1) {
                endOk = true;
                this.Close();
            } else {
                MessageBox.Show(parent, "No user selected");
            }
        }

        private void Rename() {
            if (lbxUsers.SelectedIndex != -1) {
                getUsername(Program.db.Users.Where(x => x.Username == (string)lbxUsers.SelectedItem).First());
            } else {
                MessageBox.Show(parent, "No user selected");
            }
        }

        private void New() { getUsername(new User()); }

        private void getUsername(User u) {
            String result = InputDialog.ShowDialog(parent, "Enter a new Username", "Set Username", u.Username);
            if (u.Username != result && result != null && result != "") {
                u.Username = result;
                if (Program.db.Users.Where(x => x.Username == result).Any()) {
                    MessageBox.Show(parent, "Username \"" + result + "\" is already in use");
                } else {
                    try {
                        if (u.ID == 0) { Program.db.Users.Add(u); } else { }
                        Program.db.SaveChanges();
                        getList();
                    } catch {
                        MessageBox.Show(parent, "An unkown exception has occured");
                    }
                }
            }
        }
    }
}
