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
    public partial class AmountDialog : Form {
        private AmountDialog(double val) {
            InitializeComponent();
            this.numAmount.Value = (decimal)val;
            numAmount.Focus();
        }

        public static double? ShowDialog(double val = 0) {
            AmountDialog i = new AmountDialog(val);
            if (i.ShowDialog(Program.Window) == DialogResult.OK) {
                return (double)i.numAmount.Value;
            }
            return null;
        }
    }
}
