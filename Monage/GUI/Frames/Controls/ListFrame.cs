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
        protected ListFrame(string category) {
            InitializeComponent();
            lblCategory.Text = category;
        }
        public override string TitleAppend() { return "Manage List"; }
        public override bool Ready(string con, string conf) { return true; }
        protected virtual void btnNew_Click(object sender, EventArgs e) { }
        protected void setList(List<ListItem> items) {
            lbxList.Controls.Clear();
            int cnt = 0;
            foreach (ListItem item in items) {
                item.Location = new Point(3, 7 + 80 * cnt);
                lbxList.Controls.Add(item);
                ++cnt;
            }
        }
    }
    public class Buckets : ListFrame {
        public Buckets() : base("Buckets") { }
        public override string TitleAppend() { return "Manage Buckets"; }
        public override bool Ready(string con, string conf) { return Program.ConfirmReady(con, conf); }
        public override void Set(Shell p, Panel c) {
            base.Set(p, c);
            getList();
        }
        protected override void btnNew_Click(object sender, EventArgs e) {
            try {
                new Bucket(parent.User).Rename(
                    PairDialog.ShowDialog(
                        "Enter a name and description  for your new bucket",
                        "Create Bank"
                    )
                );
                getList();
            } catch (ValidationException ex) {
                MessageBox.Show(Program.Host, ex.Message);
            }
        }
        private void getList() {
            List<ListItem> list = new List<ListItem>();
            foreach (Bucket bucket in Program.db.Buckets.Where(x => x.User.ID == parent.User.ID)) {
                list.Add(new BucketListItem(bucket));
            }
            setList(list);
        }
    }
    public class Banks : ListFrame {
        public Banks() : base("Banks") { }
        public override string TitleAppend() { return "Manage Banks"; }
        public override bool Ready(string con, string conf) { return Program.ConfirmReady(con, conf); }
        public override void Set(Shell p, Panel c) {
            base.Set(p, c);
            getList();
        }
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
        private void getList() {
            List<ListItem> list = new List<ListItem>();
            foreach (Bank bank in Program.db.Banks.Where(x => x.User.ID == parent.User.ID)) {
                list.Add(new BankListItem(bank));
            }
            setList(list);
        }
    }
}
