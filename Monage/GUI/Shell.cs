using Monage.GUI.Dialogs;
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
        private const string fileFilter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
        private Frame active;
        private bool watch = false;

        #region Shell Control-Flow Management

        public Shell() {
            InitializeComponent();

            this.WindowState =
                Settings.Maximized
                ? FormWindowState.Maximized
                : FormWindowState.Normal;

            watch = true;
            this.Login(Session.User);
        }

        private void Host_SizeChanged(object sender, EventArgs e) {
            if (!watch) { return; }

            if (this.WindowState == FormWindowState.Maximized) {
                Settings.Maximized = true;
            } else if (this.WindowState != FormWindowState.Minimized) {
                Settings.Maximized = false;
            }

            if (this.active != null) { this.active.Adjust(Content); }
        }

        public bool Ready(string action = "Navigation") {
            return
                this.active != null && this.active.State == State.Confirm
                ? Program.ConfirmReady(action)
                : true;
        }

        public void SetFrame(Frame view, string action = "Navigation", bool force = false) {
            if (force || this.Ready(action)) {
                Content.Controls.Clear();
                Content.Controls.Add(view);
                this.active = view;
                this.active.Ready();
                this.active.Adjust(Content);
            }
            this.UpdateTitle();
            this.UpdateMenuBar();
        }

        public Shell UpdateTitle() {
            this.Text = "Monage - " +
                (Session.User == null ? "" :
                    Session.User.Username) +
                " " + this.active.Title();
            return this;
        }

        private void UpdateMenuBar() {
            editToolStripMenuItem.Visible = 
            transactionsToolStripMenuItem.Visible =

            logoutToolStripMenuItem.Visible =

                Session.User != null;
        }

        #endregion

        #region MenuBar Event Handlers

        private void ImportDB(object sender, EventArgs e) {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = fileFilter;
            if (openFileDialog.ShowDialog(this) == DialogResult.OK) {
                string file = openFileDialog.FileName;
            }
        }

        private void ExportDB(object sender, EventArgs e) {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = fileFilter;
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK) {
                string file = saveFileDialog.FileName;
            }
        }

        private void Print(object sender, EventArgs e) {
            MessageBox.Show("Not Implemented");
        }

        private void PrintPreview(object sender, EventArgs e) {
            MessageBox.Show("Not Implemented");
        }

        private void PrintSetup(object sender, EventArgs e) {
            MessageBox.Show("Not Implemented");
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e) {
            if (this.Ready("Logout")) {
                this.Login(Session.Logout());
            }
        }

        private void exitToolsStripMenuItem_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void budgetsToolStripMenuItem_Click(object sender, EventArgs e) {
            if (Session.User != null) {
                this.SetFrame(new BudgetFrame());
            }
        }

        private void banksAndBucketsToolStripMenuItem_Click(object sender, EventArgs e) {
            if (Session.User != null) {
                this.SetFrame(new BankFrame());
            }
        }

        private void expensesAndRevenuesToolStripMenuItem_Click(object sender, EventArgs e) {
            if (Session.User != null) {
                this.SetFrame(new FundFrame());
            }
        }

        private void transactionHistoryToolStripMenuItem_Click(object sender, EventArgs e) {
            if (Session.User != null) {
                this.SetFrame(new HistoryFrame());
            }
        }

        private void newTransactionToolStripMenuItem_Click(object sender, EventArgs e) {
            if (Session.User != null) {
                this.SetFrame(new TransactionFrame());
            }
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e) {
            new About().ShowDialog();
        }

        private void Shell_FormClosing(object sender, FormClosingEventArgs e) {
            e.Cancel = !this.Ready("Exit");
        }

        #endregion

        public Shell Login(User user) {
            Frame view =
                user == null
                ? new UsersFrame() as Frame
                : new HistoryFrame() as Frame;

            this.SetFrame(view, "Logout", true);
            return this;
        }
    }
}
