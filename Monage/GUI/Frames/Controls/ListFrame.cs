using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Monage.GUI.Frames.Controls;
using Monage.Models;
using Monage.GUI.Dialogs;
using System.ComponentModel.DataAnnotations;

namespace Monage.GUI.Frames {
    public partial class ListFrame : DockedFrame {
        public string Category {
            get { return lblCategory.Text; }
            private set { lblCategory.Text = value; }
        }
        protected ListPane Pane { get; set; }
        protected ListFrame(string category) {
            InitializeComponent();
            this.Category = category;
        }
        public override IFrame Clone() { return new ListFrame(this.Category); }
        public override string TitleAppend() { return "Manage " + this.Category; }
        public override IFrame Set(Shell p, Panel c) {
            base.Set(p, c);
            getList();
            return this;
        }
        public override bool Ready(string con, string conf) {
            return
                this.Pane != null
                ? this.Pane.Ready(con, conf)
                : true;
        }
        protected virtual void btnNew_Click(object sender, EventArgs e) { }
        protected virtual void getList() { }
        protected void setList(List<ListItem> items) {
            lbxList.Controls.Clear();
            int cnt = 0;
            foreach (ListItem item in items) {
                item.Location = new Point(3, 7 + ((item.Height) * cnt));
                lbxList.Controls.Add(item);
                ++cnt;
            }
        }
    }
    public class Buckets : ListFrame {
        public Buckets() : base("Buckets") { }
        public override IFrame Clone() { return new Buckets(); }
        protected override void btnNew_Click(object sender, EventArgs e) {
            try {
                new Bucket(parent.User).Rename(
                    PairDialog.ShowDialog(
                        "Enter a name and description  for your new bucket",
                        "Create Bucket"
                    )
                );
                getList();
            } catch (ValidationException ex) {
                MessageBox.Show(Program.Host, ex.Message);
            }
        }
        protected override void getList() {
            List<ListItem> list = new List<ListItem>();
            foreach (Bucket bucket in Program.db.Buckets.Where(x => x.User.ID == parent.User.ID).OrderBy(x => x.Name).ToList()) {
                list.Add(new BucketListItem(bucket));
            }
            setList(list);
        }
    }
    public class Banks : ListFrame {
        public Banks() : base("Banks") { }
        public override IFrame Clone() { return new Banks(); }
        protected override void btnNew_Click(object sender, EventArgs e) {
            try {
                new Bank(parent.User).Rename(
                    PairDialog.ShowDialog(
                        "Enter a name and description for your new bank",
                        "Create Bank"
                    )
                );
                getList();
            } catch (ValidationException ex) {
                MessageBox.Show(Program.Host, ex.Message);
            }
        }
        protected override void getList() {
            List<ListItem> list = new List<ListItem>();
            foreach (Bank bank in Program.db.Banks.Where(x => x.User.ID == parent.User.ID).OrderBy(x => x.Name).ToList()) {
                list.Add(new BankListItem(bank));
            }
            setList(list);
        }
    }
    public class Budgets : ListFrame {
        public Budgets() : base("Budgets") { }
        public override IFrame Clone() { return new Budgets(); }

        protected override void btnNew_Click(object sender, EventArgs e) {
            try {
                new Budget(parent.User).Rename(
                    PairDialog.ShowDialog(
                        "Enter a name and description for your new budget",
                        "Create Budget"
                    )
                );
                getList();
            } catch (ValidationException ex) {
                MessageBox.Show(Program.Host, ex.Message);
            }
        }
        protected override void getList() {
            List<ListItem> list = new List<ListItem>();
            foreach (Bank bank in Program.db.Banks.Where(x => x.User.ID == parent.User.ID).OrderBy(x => x.Name).ToList()) {
                list.Add(new BankListItem(bank));
            }
            setList(list);
        }
    }
}
