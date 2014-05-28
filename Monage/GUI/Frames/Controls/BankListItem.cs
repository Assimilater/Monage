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

namespace Monage.GUI.Frames.Controls {
    public partial class BankListItem : UserControl {
        private Bank bank;
        public BankListItem(Bank b) {
            InitializeComponent();
            bank = b;
            lblName.Text = bank.Name;
            lblAmount.Text = bank.Balance.ToString();
        }

        private void refRename_Click(object sender, EventArgs e) {

        }
    }
}
