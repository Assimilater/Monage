﻿using System;
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

namespace Monage.GUI.Lists {
    public partial class FundListItem : ListItem {
        public FundListItem() {
            InitializeComponent();
            lblName.Click += this.ListItem_Click;
        }
        protected string Caption { get { return lblName.Text; } set { lblName.Text = value; } }
        protected virtual void refRename_Click(object sender, EventArgs e) { }
        protected virtual void refDelete_Click(object sender, EventArgs e) { }
    }
    public class BudgetListItem : FundListItem {
        private Budget Budget { get; set; }
        public BudgetListItem(Budget budget) {
            Budget = budget;
        }
    }
    public class ExReListItem : FundListItem {
        private Fund Fund { get; set; }
        public ExReListItem(Fund fund) : base() { this.Fund = fund; this.SetText(); }
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
                MessageBox.Show(Program.Host, ex.Message);
            }
        }
        protected override void refDelete_Click(object sender, EventArgs e) {

        }
    }
}
