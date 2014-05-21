using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Monage.Models;
using Monage.GUI.Dialogs;

namespace Monage.GUI.Frames {
    public partial class Users : UserControl, Frame {
        MainFrame parent;
        Panel canvas;
        public Users() {
            InitializeComponent();
        }

        public void Set(MainFrame p, Panel c) {
            parent = p;
            canvas = c;
            getList();

            canvas.Controls.Clear();
            canvas.Controls.Add(this);
            Adjust();
        }
        public void Adjust() {
            this.Location = new Point(
                canvas.Width / 2 - (this.Width / 2),
                canvas.Height / 2 - (this.Height / 2)
            );
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
                parent.Open(Program.db.Users.Where(x => x.Username == (string)cbxUsers.SelectedItem).First());
            } else {
                MessageBox.Show(parent, "No user selected");
            }
        }

        private void btnNew_Click(object sender, EventArgs e) { getUsername(new User()); }
        private void btnRename_Click(object sender, EventArgs e) {
            if (cbxUsers.SelectedIndex != -1) {
                getUsername(Program.db.Users.Where(x => x.Username == (string)cbxUsers.SelectedItem).First());
            } else {
                MessageBox.Show(parent, "No user selected");
            }
        }

        private void getUsername(User u) {
            String result = InputDialog.ShowDialog(parent, "Enter a new Username", "Set Username", u.Username);
            if (u.Username != result && result != null && result != "") {
                u.Username = result;
                if (Program.db.Users.Where(x => x.Username == result).Any()) {
                    MessageBox.Show(parent, "Username \"" + result + "\" is already in use");
                } else {
                    try {
                        if (u.ID == 0) { Program.db.Users.Add(u); }
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
