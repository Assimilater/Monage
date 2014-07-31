using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Monage.Models;
using Monage.GUI.Dialogs;

namespace Monage.GUI.Lists {
    public partial class AccountListItem : ListItem {
        public AccountListItem() {
            InitializeComponent();
            lblName.Click += this.ListItem_Click;
            lblAmount.Click += this.ListItem_Click;
        }
        protected string Caption { get { return lblName.Text; } set { lblName.Text = value; } }
        protected string Amount { get { return lblAmount.Text; } set { lblAmount.Text = value; } }
        protected virtual void refRename_Click(object sender, EventArgs e) { }
        protected virtual void refDelete_Click(object sender, EventArgs e) { }
    }

    public class BankListItem : AccountListItem {
        private Bank Bank;
        public BankListItem(Bank bank) : base() { this.Bank = bank; this.SetText(); }
        private void SetText() { this.Caption = this.Bank.Name; this.Amount = this.Bank.GetBalance().ToString(); }
        protected override void refRename_Click(object sender, EventArgs e) {
            try {
                this.Bank.Rename(
                    PairDialog.ShowDialog(
                        "Enter a new name for bank: " + this.Bank.Name,
                        "Rename Bank",
                        this.Bank.Name,
                        this.Bank.Description
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

    public class BucketListItem : AccountListItem {
        private Bucket Bucket;
        public BucketListItem(Bucket bucket) : base() { this.Bucket = bucket; this.SetText(); }
        private void SetText() { this.Caption = this.Bucket.Name; this.Amount = this.Bucket.GetBalance().ToString(); }
        protected override void refRename_Click(object sender, EventArgs e) {
            try {
                this.Bucket.Rename(
                    PairDialog.ShowDialog(
                        "Enter a new name for bucket: " + this.Bucket.Name,
                        "Rename Bucket",
                        this.Bucket.Name,
                        this.Bucket.Description
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
