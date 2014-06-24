﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Monage.GUI.Frames.Controls;
using Monage.Models;
using Monage.GUI.Dialogs;

namespace Monage.GUI.Frames {
    public partial class ListFrame : UserControl {
        public string Category {
            get { return lblCategory.Text; }
            private set { lblCategory.Text = value; }
        }
        protected ListFrame(string category) {
            InitializeComponent();
            this.Category = category;
        }

        protected User User { get; set; }
        protected SummaryFrame ParentFrame { get; set; }
        public ListFrame Set(SummaryFrame parent, User user) {
            this.ParentFrame = parent;
            this.User = user;
            getList();
            return this;
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

    public class ListItem : UserControl {
        public ListItem() { this.Click += ListItem_Click; }
        public virtual ListPane getPane(Shell connection) { return null; }

        protected SummaryFrame Frame { get; set; }
        public ListItem SetFrame(SummaryFrame frame) {
            this.Frame = frame;
            return this;
        }

        protected void ListItem_Click(object sender, EventArgs e) {
            Frame.SelectItem(this);
        }
        public void Toggle(bool isSelected) {
            this.BackColor =
                isSelected
                ? System.Drawing.SystemColors.ActiveCaption
                : System.Drawing.SystemColors.Control;
        }
    }

    public class ListPane : UserControl {
        protected Shell Connection { get; set; }
        public ListPane Set(Shell connection) {
            this.Connection = connection;
            this.getInfo();
            return this;
        }

        protected virtual ListPane getInfo() { return this; }
        public virtual bool Ready(string conf) { return true; }
    }
    
    public class BucketsFrame : ListFrame {
        public BucketsFrame() : base("Buckets") { }

        protected override void btnNew_Click(object sender, EventArgs e) {
            try {
                new Bucket(this.User).Rename(
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
            foreach (Bucket bucket in Bucket.Enumerate(this.User)) {
                list.Add(new BucketListItem(bucket).SetFrame(this.ParentFrame));
            }
            setList(list);
        }
    }

    public class BanksFrame : ListFrame {
        public BanksFrame() : base("Banks") { }

        protected override void btnNew_Click(object sender, EventArgs e) {
            try {
                new Bank(this.User).Rename(
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
            foreach (Bank bank in Bank.Enumerate(this.User)) {
                list.Add(new BankListItem(bank).SetFrame(this.ParentFrame));
            }
            setList(list);
        }
    }

    public class BudgetsFrame : ListFrame {
        public BudgetsFrame() : base("Budgets") { }

        //protected override void btnNew_Click(object sender, EventArgs e) {
        //    try {
        //        // *FIX*
        //        new Budget(this.User).Rename(
        //            PairDialog.ShowDialog(
        //                "Enter a name and description for your new budget",
        //                "Create Budget"
        //            )
        //        );
        //        getList();
        //    } catch (ValidationException ex) {
        //        MessageBox.Show(Program.Host, ex.Message);
        //    }
        //}

        protected override void getList() {
            List<ListItem> list = new List<ListItem>();
            foreach (Budget budget in Budget.Enumerate(this.User)) {
                list.Add(new BudgetListItem(budget).SetFrame(this.ParentFrame));
            }
            setList(list);
        }
    }

    public class ExpenseFrame : ListFrame {
        public ExpenseFrame() : base("Expense Categories") { }

        //protected override void btnNew_Click(object sender, EventArgs e) {
        //    try {
        //        // *FIX*
        //        new Bank(this.User).Rename(
        //            PairDialog.ShowDialog(
        //                "Enter a name and description for your new bank",
        //                "Create Bank"
        //            )
        //        );
        //        getList();
        //    } catch (ValidationException ex) {
        //        MessageBox.Show(Program.Host, ex.Message);
        //    }
        //}

        protected override void getList() {
            List<ListItem> list = new List<ListItem>();
            foreach (Expense expense in Expense.Enumerate(this.User)) {
                list.Add(new ExpenseListItem(expense).SetFrame(this.ParentFrame));
            }
            setList(list);
        }
    }

    public class RevenueFrame : ListFrame {
        public RevenueFrame() : base("Revenue Sources") { }

        //protected override void btnNew_Click(object sender, EventArgs e) {
        //    try {
        //        // *FIX*
        //        new Bank(this.User).Rename(
        //            PairDialog.ShowDialog(
        //                "Enter a name and description for your new bank",
        //                "Create Bank"
        //            )
        //        );
        //        getList();
        //    } catch (ValidationException ex) {
        //        MessageBox.Show(Program.Host, ex.Message);
        //    }
        //}

        protected override void getList() {
            List<ListItem> list = new List<ListItem>();
            foreach (Revenue revenue in Revenue.Enumerate(this.User)) {
                list.Add(new RevenueListItem(revenue).SetFrame(this.ParentFrame));
            }
            setList(list);
        }
    }
}
