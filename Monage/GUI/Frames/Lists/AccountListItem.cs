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

namespace Monage.GUI.Frames.Controls {
    public partial class AccountListItem : ListItem {
        public AccountListItem() { InitializeComponent(); }
        protected string Caption { get { return lblName.Text; } set { lblName.Text = value; } }
        protected string Amount { get { return lblAmount.Text; } set { lblAmount.Text = value; } }
        protected virtual void refRename_Click(object sender, EventArgs e) { }
        protected virtual void refDelete_Click(object sender, EventArgs e) { }
    }

    public class BankListItem : AccountListItem {
        private Bank bank;
        public BankListItem(Bank b) : base() { bank = b; SetText(); }
        private void SetText() { Caption = bank.Name; Amount = bank.GetBalance().ToString(); }
        protected override void refRename_Click(object sender, EventArgs e) {
            try {
                bank.Rename(
                    PairDialog.ShowDialog(
                        "Enter a new name for bank: " + bank.Name,
                        "Rename Bank",
                        bank.Name,
                        bank.Description
                    )
                );
                SetText();
            } catch (ValidationException ex) {
                MessageBox.Show(Program.Host, ex.Message);
            }
        }
        protected override void refDelete_Click(object sender, EventArgs e) {

        }
    }

    public class BucketListItem : AccountListItem {
        private Bucket bucket;
        public BucketListItem(Bucket b) : base() { bucket = b; SetText(); }
        private void SetText() { Caption = bucket.Name; Amount = bucket.GetBalance().ToString(); }
        protected override void refRename_Click(object sender, EventArgs e) {
            try {
                bucket.Rename(
                    PairDialog.ShowDialog(
                        "Enter a new name for bucket: " + bucket.Name,
                        "Rename Bucket",
                        bucket.Name,
                        bucket.Description
                    )
                );
                SetText();
            } catch (ValidationException ex) {
                MessageBox.Show(Program.Host, ex.Message);
            }
        }
        protected override void refDelete_Click(object sender, EventArgs e) {

        }
    }

}
