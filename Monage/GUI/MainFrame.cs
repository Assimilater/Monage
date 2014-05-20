using Monage.GUI.Dialogs;
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
        private Context db;
        private User user;

        public MainFrame() {
            InitializeComponent();
        }

        public void Open(int userID) {
            db = new Context();
            user = db.Users.Where(x => x.ID == (int)userID).First();
            MessageBox.Show("Hi " + user.Username + "!");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void switchUserToolStripMenuItem_Click(object sender, EventArgs e) {
            int? userID = UserDialog.SelectUser();
            if (userID != null) {
                Open((int)userID);
            }
        }
    }
}
