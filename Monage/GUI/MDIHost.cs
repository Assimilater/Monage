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
        private int childFormNumber = 0;
        private const string fileFilter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

        public MDIHost() {
            InitializeComponent();
        }

        public string AddShell(Shell c) {
            c.MdiParent = this;
            return "Connection " + childFormNumber++;
        }

        private void NewConnection(object sender, EventArgs e) {
            Shell childForm = new Shell("Connection " + childFormNumber++);
            childForm.MdiParent = this;
            childForm.Show();
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

        #region MenuBar Event Handlers

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e) {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e) {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
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
            foreach (Form childForm in MdiChildren) {
                childForm.Close();
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e) {
            new About().ShowDialog();
        }

        #endregion
    }
}
