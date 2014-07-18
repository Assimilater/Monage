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
    public partial class DebitDialog : Form {
        private DebitDialog(string prompt, string caption, string name, string description) {
            InitializeComponent();
            this.Text = caption;
            
        }

        public static Pair ShowDialog(string prompt, string caption, string val = "", string description = "") {
            DebitDialog i = new DebitDialog(prompt, caption, val, description);
            return null;
        }
    }
}
