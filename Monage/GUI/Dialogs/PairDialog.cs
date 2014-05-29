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

namespace Monage.GUI.Dialogs {
    public partial class PairDialog : Form {
        private PairDialog(string prompt, string caption, string name, string description) {
            InitializeComponent();
            this.Text = caption;
            this.lblPrompt.Text = prompt;
            this.txtName.Text = name;
            this.txtDescription.Text = description;
            txtName.Focus();
        }

        public static Pair ShowDialog(string prompt, string caption, string val = "", string description = "") {
            PairDialog i = new PairDialog(prompt, caption, val, description);
            return
                i.ShowDialog(Program.Host) == DialogResult.OK
                ? new Pair(i.txtName.Text, i.txtDescription.Text)
                : null;
        }
    }
}
