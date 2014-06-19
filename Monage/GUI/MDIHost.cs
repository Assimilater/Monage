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
    public partial class MDIHost : Form {
        private const string fileFilter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
        private string IdShell() { return "Connection " + childFormNumber++; }
        private int childFormNumber = 0;
        private bool watch = false;

        public MDIHost() {
            InitializeComponent();

            this.WindowState =
                Settings.Maximized
                ? FormWindowState.Maximized
                : FormWindowState.Normal;

            watch = true;

            ConnectShell(new Shell(IdShell())); 
        }

        private void MDIHost_Adjust(object sender, EventArgs e) {
            if (!watch) { return; }
            
            if (this.WindowState == FormWindowState.Maximized) {
                Settings.Maximized = true;
            } else if (this.WindowState != FormWindowState.Minimized) {
                Settings.Maximized = false;
            }
        }

        public string AddShell(Shell c) {
            ConnectShell(c);
            return IdShell();
        }

        private void ConnectShell(Shell c) {
            c.MdiParent = this;
            c.Show();
            c.Activate();
            if (MdiChildren.Count() == 1) {
                c.WindowState = FormWindowState.Maximized;
            }
        }

        #region MenuBar Event Handlers

        private void NewConnection(object sender, EventArgs e) {
            ConnectShell(new Shell(IdShell())); 
        }

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
            throw new NotImplementedException();
        }

        private void PrintPreview(object sender, EventArgs e) {
            throw new NotImplementedException();
        }

        private void PrintSetup(object sender, EventArgs e) {
            throw new NotImplementedException();
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e) {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e) {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void OptionsToolStripMenuItem_Click(object sender, EventArgs e) {
            throw new NotImplementedException();
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e) {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e) {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e) {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e) {
            Ready();
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e) {
            new About().ShowDialog();
        }

        #endregion

        private void MDIHost_FormClosing(object sender, FormClosingEventArgs e) {
            e.Cancel = !Ready();
        }

        private bool Ready() {
            foreach (Shell childForm in MdiChildren) {
                if (childForm.Ready("Close")) {
                    childForm.Close();
                } else {
                    return false;
                }
            }
            return true;
        }
    }
}
