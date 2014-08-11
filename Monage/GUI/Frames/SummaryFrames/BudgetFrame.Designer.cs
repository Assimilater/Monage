using Monage.GUI.Lists;
namespace Monage.GUI.Frames {
    partial class BudgetFrame {
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.budgetsFrame = new Monage.GUI.Lists.BudgetsList();
            this.pnlEditor = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // budgetsFrame
            // 
            this.budgetsFrame.AutoScroll = true;
            this.budgetsFrame.Dock = System.Windows.Forms.DockStyle.Left;
            this.budgetsFrame.Location = new System.Drawing.Point(0, 0);
            this.budgetsFrame.Name = "budgetsFrame";
            this.budgetsFrame.Size = new System.Drawing.Size(306, 582);
            this.budgetsFrame.TabIndex = 4;
            // 
            // pnlEditor
            // 
            this.pnlEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEditor.Location = new System.Drawing.Point(306, 0);
            this.pnlEditor.Name = "pnlEditor";
            this.pnlEditor.Size = new System.Drawing.Size(764, 582);
            this.pnlEditor.TabIndex = 5;
            // 
            // BudgetFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlEditor);
            this.Controls.Add(this.budgetsFrame);
            this.Name = "BudgetFrame";
            this.Size = new System.Drawing.Size(1070, 582);
            this.ResumeLayout(false);

        }

        #endregion

        private BudgetsList budgetsFrame;
        private System.Windows.Forms.Panel pnlEditor;


    }
}
