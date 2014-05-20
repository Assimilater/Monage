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
        private bool endOk;
        private InputDialog(string prompt, string caption, string val) {
            InitializeComponent();
            endOk = false;
            this.Text = caption;
            this.lblPrompt.Text = prompt;
            this.txtResponse.Text = val;
            txtResponse.Focus();
        }

        public static String ShowDialog(string prompt, string caption, string val = "") {
            InputDialog i = new InputDialog(prompt, caption, val);
            return i.ShowDialog() == DialogResult.OK ? i.txtResponse.Text : null;
        }

        private void InputDialog_FormClosing(object sender, FormClosingEventArgs e) {
            this.DialogResult = endOk ? DialogResult.OK : DialogResult.Cancel;
        }
        
        private void btnOk_Click(object sender, EventArgs e) {
            endOk = true;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
