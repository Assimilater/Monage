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

namespace Monage.GUI.Lists {
    public partial class FundListItem : ListItem {
        public FundListItem() {
            InitializeComponent();
            lblName.Click += this.ListItem_Click;
        }
    }
    public class BudgetListItem : FundListItem {
        private Budget Budget { get; set; }
        public BudgetListItem(Budget budget) {
            Budget = budget;
        }
    }
    public class ExReListItem : FundListItem {
        private Fund Fund { get; set; }
        public ExReListItem(Fund fund) {
            Fund = fund;
        }
    }
}
