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
    public partial class InputDialog : Form {
        private InputDialog(string prompt, string caption, string val) {
            InitializeComponent();
            this.Text = caption;
            this.lblPrompt.Text = prompt;
            this.txtResponse.Text = val;
            txtResponse.Focus();
        }

        public static String ShowDialog(string prompt, string caption, string val = "") {
            InputDialog i = new InputDialog(prompt, caption, val);
            return i.ShowDialog(Program.Host) == DialogResult.OK ? i.txtResponse.Text : null;
        }
    }
}
