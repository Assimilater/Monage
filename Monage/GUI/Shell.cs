﻿using Monage.GUI.Dialogs;
using Monage.GUI.Frames;
using Monage.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monage.GUI {
    public partial class Shell : Form {
        public User User { get; private set; }
        public string ConnectionString { get; private set; }
        private IFrame active;

        #region Shell Control-Flow Management
        
        public Shell(string con) {
            InitializeComponent();

            ConnectionString = con;

            Login(
                (Program.db.Users.Count() == 1 && Settings.ActiveUser == Settings.NullInt)
                ? Program.db.Users.First()
                : Program.db.Users.FirstOrDefault(x => x.ID == Settings.ActiveUser)
            );
        }

        private void cloneConnectionToolStripMenuItem_Click(object sender, EventArgs e) {
            Program.Host.AddShell(new Shell(this, active));
        }

        public Shell(Shell copy, IFrame view) {
            InitializeComponent();

            ConnectionString = Program.Host.AddShell(this);
            User = copy.User;
            SetFrame(new SummaryFrame());
        }

        public bool Ready(string conf = "Navigation") {
            return
                active != null
                ? active.Ready(conf)
                : true;
        }

        private void SetFrame(IFrame view, string conf = "Navigation") {
            if (Ready(conf)) {
                active = view;
                active.Set(this, Content);
            }
            UpdateShell();
        }

        private void Content_Resize(object sender, EventArgs e) {
            foreach (IFrame c in Content.Controls) { c.Adjust(); }
        }

        private void UpdateShell() {
            UpdateTitle();
            UpdateMenuBar();
        }

        public void UpdateTitle() {
            this.Text = ConnectionString + (
                User == null
                ? ""
                : " - " + (
                    User.Username + (
                        active != null
                        ? ": " + active.Title()
                        : ""
                    )
                )
            );
        }

        private void UpdateMenuBar() {
            accountSummaryToolStripMenuItem.Visible = 
            newTransactionToolStripMenuItem.Visible =
            transactionHistoryToolStripMenuItem.Visible =

            toolStripSeparator1.Visible =
            logoutToolStripMenuItem.Visible =

                User != null;
        }

        #endregion

        #region MenuBar Event Handlers
        
        private void summaryToolStripMenuItem_Click(object sender, EventArgs e) {
            if (User != null) {
                SetFrame(new SummaryFrame());
            }
        }

        private void newTransactionToolStripMenuItem_Click(object sender, EventArgs e) {
            if (User != null) {
                SetFrame(new TransactionFrame());
            }
        }

        private void historyToolStripMenuItem_Click(object sender, EventArgs e) {
            if (User != null) {
                SetFrame(new HistoryFrame());
            }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e) {
            Login(null);
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e) {
            if (Ready("Close")) {
                this.Close();
            }
        }

        #endregion

        public void Login(User u) {
            User = u;
            Settings.ActiveUser = User == null ? -1 : User.ID;

            IFrame view =
                User == null
                ? new UsersFrame() as IFrame
                : new SummaryFrame() as IFrame;

            SetFrame(view, "Logout");
        }
    }
}
