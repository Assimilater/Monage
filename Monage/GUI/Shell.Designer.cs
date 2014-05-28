namespace Monage.GUI {
    partial class Shell {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.MenuBar = new System.Windows.Forms.MenuStrip();
            this.connectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.summaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newTransactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.banksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bucketsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.budgetsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Content = new System.Windows.Forms.Panel();
            this.MenuBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuBar
            // 
            this.MenuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectionToolStripMenuItem});
            this.MenuBar.Location = new System.Drawing.Point(0, 0);
            this.MenuBar.Name = "MenuBar";
            this.MenuBar.Size = new System.Drawing.Size(772, 28);
            this.MenuBar.TabIndex = 0;
            this.MenuBar.Text = "MenuStrip";
            this.MenuBar.Visible = false;
            // 
            // connectionToolStripMenuItem
            // 
            this.connectionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.summaryToolStripMenuItem,
            this.newTransactionToolStripMenuItem,
            this.historyToolStripMenuItem,
            this.toolStripSeparator1,
            this.banksToolStripMenuItem,
            this.bucketsToolStripMenuItem,
            this.budgetsToolStripMenuItem,
            this.toolStripSeparator2,
            this.logoutToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.connectionToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.MatchOnly;
            this.connectionToolStripMenuItem.MergeIndex = 1;
            this.connectionToolStripMenuItem.Name = "connectionToolStripMenuItem";
            this.connectionToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.connectionToolStripMenuItem.Text = "&Connection";
            // 
            // summaryToolStripMenuItem
            // 
            this.summaryToolStripMenuItem.Name = "summaryToolStripMenuItem";
            this.summaryToolStripMenuItem.Size = new System.Drawing.Size(258, 24);
            this.summaryToolStripMenuItem.Text = "&Summary";
            this.summaryToolStripMenuItem.Click += new System.EventHandler(this.summaryToolStripMenuItem_Click);
            // 
            // newTransactionToolStripMenuItem
            // 
            this.newTransactionToolStripMenuItem.Name = "newTransactionToolStripMenuItem";
            this.newTransactionToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.newTransactionToolStripMenuItem.Size = new System.Drawing.Size(258, 24);
            this.newTransactionToolStripMenuItem.Text = "New &Transaction";
            this.newTransactionToolStripMenuItem.Click += new System.EventHandler(this.newTransactionToolStripMenuItem_Click);
            // 
            // historyToolStripMenuItem
            // 
            this.historyToolStripMenuItem.Name = "historyToolStripMenuItem";
            this.historyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.historyToolStripMenuItem.Size = new System.Drawing.Size(258, 24);
            this.historyToolStripMenuItem.Text = "Transaction &History";
            this.historyToolStripMenuItem.Click += new System.EventHandler(this.historyToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(255, 6);
            // 
            // banksToolStripMenuItem
            // 
            this.banksToolStripMenuItem.Name = "banksToolStripMenuItem";
            this.banksToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D1)));
            this.banksToolStripMenuItem.Size = new System.Drawing.Size(258, 24);
            this.banksToolStripMenuItem.Text = "B&anks";
            this.banksToolStripMenuItem.Click += new System.EventHandler(this.banksToolStripMenuItem_Click);
            // 
            // bucketsToolStripMenuItem
            // 
            this.bucketsToolStripMenuItem.Name = "bucketsToolStripMenuItem";
            this.bucketsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D2)));
            this.bucketsToolStripMenuItem.Size = new System.Drawing.Size(258, 24);
            this.bucketsToolStripMenuItem.Text = "B&uckets";
            this.bucketsToolStripMenuItem.Click += new System.EventHandler(this.bucketsToolStripMenuItem_Click);
            // 
            // budgetsToolStripMenuItem
            // 
            this.budgetsToolStripMenuItem.Name = "budgetsToolStripMenuItem";
            this.budgetsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D3)));
            this.budgetsToolStripMenuItem.Size = new System.Drawing.Size(258, 24);
            this.budgetsToolStripMenuItem.Text = "&Budgets";
            this.budgetsToolStripMenuItem.Click += new System.EventHandler(this.budgetsToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(255, 6);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.Delete)));
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(258, 24);
            this.logoutToolStripMenuItem.Text = "&Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(258, 24);
            this.closeToolStripMenuItem.Text = "&Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // Content
            // 
            this.Content.AutoScroll = true;
            this.Content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Content.Location = new System.Drawing.Point(0, 0);
            this.Content.Name = "Content";
            this.Content.Size = new System.Drawing.Size(772, 377);
            this.Content.TabIndex = 1;
            this.Content.Resize += new System.EventHandler(this.Content_Resize);
            // 
            // Shell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 377);
            this.Controls.Add(this.Content);
            this.Controls.Add(this.MenuBar);
            this.Icon = global::Monage.Properties.Resources.favicon;
            this.MainMenuStrip = this.MenuBar;
            this.Name = "Shell";
            this.Text = "Shell";
            this.MenuBar.ResumeLayout(false);
            this.MenuBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuBar;
        private System.Windows.Forms.Panel Content;
        private System.Windows.Forms.ToolStripMenuItem connectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem banksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bucketsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem budgetsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem newTransactionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem summaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historyToolStripMenuItem;
    }
}