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
    public class ExpenseListItem : FundListItem {
        private Expense Expense { get; set; }
        public ExpenseListItem(Expense expense) {
            Expense = expense;
        }
    }
    public class RevenueListItem : FundListItem {
        private Revenue Revenue { get; set; }
        public RevenueListItem(Revenue revenue) {
            Revenue = revenue;
        }
    }
}
