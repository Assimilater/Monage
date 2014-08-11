using Monage.GUI.Lists;
namespace Monage.GUI.Frames {
    partial class FundFrame {
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
            this.expenseFrame = new Monage.GUI.Lists.ExpensesList();
            this.revenueFrame = new Monage.GUI.Lists.RevenuesList();
            this.pnlEditor = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // expenseFrame
            // 
            this.expenseFrame.Dock = System.Windows.Forms.DockStyle.Left;
            this.expenseFrame.Location = new System.Drawing.Point(306, 0);
            this.expenseFrame.Name = "expenseFrame";
            this.expenseFrame.Size = new System.Drawing.Size(306, 582);
            this.expenseFrame.TabIndex = 7;
            // 
            // revenueFrame
            // 
            this.revenueFrame.Dock = System.Windows.Forms.DockStyle.Left;
            this.revenueFrame.Location = new System.Drawing.Point(0, 0);
            this.revenueFrame.Name = "revenueFrame";
            this.revenueFrame.Size = new System.Drawing.Size(306, 582);
            this.revenueFrame.TabIndex = 6;
            // 
            // pnlEditor
            // 
            this.pnlEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEditor.Location = new System.Drawing.Point(612, 0);
            this.pnlEditor.Name = "pnlEditor";
            this.pnlEditor.Size = new System.Drawing.Size(458, 582);
            this.pnlEditor.TabIndex = 8;
            // 
            // ExReFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlEditor);
            this.Controls.Add(this.expenseFrame);
            this.Controls.Add(this.revenueFrame);
            this.Name = "ExReFrame";
            this.Size = new System.Drawing.Size(1070, 582);
            this.ResumeLayout(false);

        }

        #endregion

        private ExpensesList expenseFrame;
        private RevenuesList revenueFrame;
        private System.Windows.Forms.Panel pnlEditor;


    }
}
