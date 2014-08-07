using Monage.GUI.Lists;
namespace Monage.GUI.Frames {
    partial class SummaryFrame {
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
            this.bucketsFrame = new Monage.GUI.Lists.BucketsList();
            this.banksFrame = new Monage.GUI.Lists.BanksList();
            this.expenseFrame = new Monage.GUI.Lists.ExpensesList();
            this.revenueFrame = new Monage.GUI.Lists.RevenuesList();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // budgetsFrame
            // 
            this.budgetsFrame.AutoScroll = true;
            this.budgetsFrame.Dock = System.Windows.Forms.DockStyle.Left;
            this.budgetsFrame.Location = new System.Drawing.Point(612, 0);
            this.budgetsFrame.Name = "budgetsFrame";
            this.budgetsFrame.Size = new System.Drawing.Size(306, 578);
            this.budgetsFrame.TabIndex = 3;
            // 
            // bucketsFrame
            // 
            this.bucketsFrame.AutoScroll = true;
            this.bucketsFrame.Dock = System.Windows.Forms.DockStyle.Left;
            this.bucketsFrame.Location = new System.Drawing.Point(306, 0);
            this.bucketsFrame.Name = "bucketsFrame";
            this.bucketsFrame.Size = new System.Drawing.Size(306, 578);
            this.bucketsFrame.TabIndex = 2;
            // 
            // banksFrame
            // 
            this.banksFrame.AutoScroll = true;
            this.banksFrame.Dock = System.Windows.Forms.DockStyle.Left;
            this.banksFrame.Location = new System.Drawing.Point(0, 0);
            this.banksFrame.Name = "banksFrame";
            this.banksFrame.Size = new System.Drawing.Size(306, 578);
            this.banksFrame.TabIndex = 1;
            // 
            // expenseFrame
            // 
            this.expenseFrame.Dock = System.Windows.Forms.DockStyle.Left;
            this.expenseFrame.Location = new System.Drawing.Point(1224, 0);
            this.expenseFrame.Name = "expenseFrame";
            this.expenseFrame.Size = new System.Drawing.Size(306, 578);
            this.expenseFrame.TabIndex = 5;
            // 
            // revenueFrame
            // 
            this.revenueFrame.Dock = System.Windows.Forms.DockStyle.Left;
            this.revenueFrame.Location = new System.Drawing.Point(918, 0);
            this.revenueFrame.Name = "revenueFrame";
            this.revenueFrame.Size = new System.Drawing.Size(306, 578);
            this.revenueFrame.TabIndex = 4;
            // 
            // splitContainer
            // 
            this.splitContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.AutoScroll = true;
            this.splitContainer.Panel1.Controls.Add(this.expenseFrame);
            this.splitContainer.Panel1.Controls.Add(this.revenueFrame);
            this.splitContainer.Panel1.Controls.Add(this.budgetsFrame);
            this.splitContainer.Panel1.Controls.Add(this.bucketsFrame);
            this.splitContainer.Panel1.Controls.Add(this.banksFrame);
            this.splitContainer.Size = new System.Drawing.Size(1800, 582);
            this.splitContainer.SplitterDistance = 1534;
            this.splitContainer.TabIndex = 16;
            this.splitContainer.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer_SplitterMoved);
            // 
            // SummaryFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer);
            this.Name = "SummaryFrame";
            this.Size = new System.Drawing.Size(1800, 582);
            this.splitContainer.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private BanksList banksFrame;
        private BucketsList bucketsFrame;
        private BudgetsList budgetsFrame;
        private ExpensesList expenseFrame;
        private RevenuesList revenueFrame;
        private System.Windows.Forms.SplitContainer splitContainer;

    }
}
