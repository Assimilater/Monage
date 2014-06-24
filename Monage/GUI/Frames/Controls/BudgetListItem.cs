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
    public partial class BudgetListItem : UserControl {
        private Budget Budget;
        public BudgetListItem(Budget b) {
            InitializeComponent();
            Budget = b;
        }
    }
}
