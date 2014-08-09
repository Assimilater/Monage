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
    public partial class ConfirmedDialog : Form {
        private bool watch;
        private ConfirmedDialog() {
            this.watch = false;
            InitializeComponent();
            dtConfirm.Value = dtTime.Value = DateTime.Now;
            this.watch = true;
        }

        private void dtConfirm_ValueChanged(object sender, EventArgs e) {
            if (this.watch) {
                this.watch = false;
                dtTime.Value = dtConfirm.Value;
                this.watch = true;
            }
        }
        private void dtTime_ValueChanged(object sender, EventArgs e) {
            if (this.watch) {
                this.watch = false;
                dtConfirm.Value = dtTime.Value;
                this.watch = true;
            }
        }

        private void SetPrompt(string incurred, string brief, string cashflow) {
            lblPrompt.Text =
                "Confirmation that the following transaction:" + Environment.NewLine +
                Environment.NewLine +
                Environment.NewLine +
                brief + Environment.NewLine +
                "Incurred On: " + incurred + Environment.NewLine +
                "Cashflow: " + cashflow + Environment.NewLine +
                Environment.NewLine +
                Environment.NewLine +
                "Was proccessed by the bank on:";
        }
        private void SetPrompt(string incurred, string brief, string affecting, string before, string after) {
            lblPrompt.Text =
                "Confirmation that the following transaction:" + Environment.NewLine +
                Environment.NewLine +
                brief + Environment.NewLine +
                "Incurred On: " + incurred + Environment.NewLine +
                "Affecting: " + affecting + Environment.NewLine +
                "Prior Balance: " + before + Environment.NewLine +
                "Remaining Balance: " + after + Environment.NewLine +
                Environment.NewLine +
                "Was proccessed by the bank on:";
        }

        public static DateTime? ShowDialog(string incurred, string brief, string cashflow) {
            ConfirmedDialog i = new ConfirmedDialog();
            i.SetPrompt(incurred, brief, cashflow);

            if (i.ShowDialog(Program.Window) == DialogResult.OK) {
                return i.dtConfirm.Value;
            }
            return null;
        }
        public static DateTime? ShowDialog(string incurred, string brief, string affecting, string before, string after) {
            ConfirmedDialog i = new ConfirmedDialog();
            i.SetPrompt(incurred, brief, affecting, before, after);

            if (i.ShowDialog(Program.Window) == DialogResult.OK) {
                return i.dtConfirm.Value;
            }
            return null;
        }
    }
}
