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
using Monage.GUI.Dialogs;
using System.ComponentModel.DataAnnotations;
using Monage.GUI.Frames;

namespace Monage.GUI.Lists {
    public partial class BasicListItem : ListItem {
        public BasicListItem() {
            InitializeComponent();
            lblName.Click += this.ListItem_Click;
        }
        protected string Caption { get { return lblName.Text; } set { lblName.Text = value; } }
        protected virtual void refRename_Click(object sender, EventArgs e) { }
        protected virtual void refDelete_Click(object sender, EventArgs e) { }
    }
    public class BudgetListItem : BasicListItem {
        private Budget Budget { get; set; }
        public BudgetListItem(Budget budget) { this.Budget = budget; this.SetText(); }
        public override Frame getPane() { return new BudgetListPane(this.Budget, this.Frame); }

        private void SetText() { this.Caption = this.Budget.Name; }
        protected override void refRename_Click(object sender, EventArgs e) {
            try {
                this.Budget.Rename(
                    BudgetDialog.ShowDialog(
                        "Enter a new name for Budget: " + this.Budget.Name,
                        "Rename Budget",
                        this.Budget.Name,
                        this.Budget.Description,
                        this.Budget.Final_ID
                    )
                );
                this.SetText();
            } catch (ValidationException ex) {
                MessageBox.Show(Program.Window, ex.Message);
            }
        }

        protected override void refDelete_Click(object sender, EventArgs e) {

        }
    }
    public class FundListItem : BasicListItem {
        private Fund Fund { get; set; }
        public FundListItem(Fund fund) { this.Fund = fund; this.SetText(); }

        private void SetText() { this.Caption = this.Fund.Name; }
        protected override void refRename_Click(object sender, EventArgs e) {
            string type = this.Fund.BalanceType == BalanceType.Debit
                ? "Expense Category"
                : "Revenue Source";

            try {
                this.Fund.Rename(
                    PairDialog.ShowDialog(
                        "Enter a new name for " + type.ToLower() + ": " + this.Fund.Name,
                        "Rename " + type,
                        this.Fund.Name,
                        this.Fund.Description
                    )
                );
                this.SetText();
            } catch (ValidationException ex) {
                MessageBox.Show(Program.Window, ex.Message);
            }
        }

        protected override void refDelete_Click(object sender, EventArgs e) {

        }
    }
}
