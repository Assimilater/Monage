using Monage.GUI.Dialogs;
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
        private int userID;
        public MainFrame() {
            InitializeComponent();
        }
        public void Open(int uID) {
            userID = uID;
            using (Context db = new Context()) {
                MessageBox.Show("Hi " + db.Users.Where(x => x.ID == (int)userID).First().Username + "!");
            }
        }
    }
}
