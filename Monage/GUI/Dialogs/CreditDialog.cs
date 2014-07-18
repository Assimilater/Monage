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
    public partial class CreditDialog : Form {
        private CreditDialog(string prompt, string caption, string name, string description) {
            InitializeComponent();
            this.Text = caption;
            
        }

        public static Pair ShowDialog(string prompt, string caption, string val = "", string description = "") {
            CreditDialog i = new CreditDialog(prompt, caption, val, description);
            return null;
        }
    }
}
