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
            this.budgetsFrame = new Monage.GUI.Frames.BudgetsFrame();
            this.bucketsFrame = new Monage.GUI.Frames.BucketsFrame();
            this.banksFrame = new Monage.GUI.Frames.BanksFrame();
            this.expenseFrame = new Monage.GUI.Frames.ExpenseFrame();
            this.revenueFrame = new Monage.GUI.Frames.RevenueFrame();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // budgetsFrame
            // 
            this.budgetsFrame.AutoScroll = true;
            this.budgetsFrame.Dock = System.Windows.Forms.DockStyle.Left;
            this.budgetsFrame.Location = new System.Drawing.Point(0, 0);
            this.budgetsFrame.Name = "budgetsFrame";
            this.budgetsFrame.Size = new System.Drawing.Size(306, 561);
            this.budgetsFrame.TabIndex = 3;
            // 
            // bucketsFrame
            // 
            this.bucketsFrame.AutoScroll = true;
            this.bucketsFrame.Dock = System.Windows.Forms.DockStyle.Left;
            this.bucketsFrame.Location = new System.Drawing.Point(612, 0);
            this.bucketsFrame.Name = "bucketsFrame";
            this.bucketsFrame.Size = new System.Drawing.Size(306, 561);
            this.bucketsFrame.TabIndex = 2;
            // 
            // banksFrame
            // 
            this.banksFrame.AutoScroll = true;
            this.banksFrame.Dock = System.Windows.Forms.DockStyle.Left;
            this.banksFrame.Location = new System.Drawing.Point(1224, 0);
            this.banksFrame.Name = "banksFrame";
            this.banksFrame.Size = new System.Drawing.Size(306, 561);
            this.banksFrame.TabIndex = 1;
            // 
            // expenseFrame
            // 
            this.expenseFrame.Dock = System.Windows.Forms.DockStyle.Left;
            this.expenseFrame.Location = new System.Drawing.Point(306, 0);
            this.expenseFrame.Name = "expenseFrame";
            this.expenseFrame.Size = new System.Drawing.Size(306, 561);
            this.expenseFrame.TabIndex = 5;
            // 
            // revenueFrame
            // 
            this.revenueFrame.Dock = System.Windows.Forms.DockStyle.Left;
            this.revenueFrame.Location = new System.Drawing.Point(918, 0);
            this.revenueFrame.Name = "revenueFrame";
            this.revenueFrame.Size = new System.Drawing.Size(306, 561);
            this.revenueFrame.TabIndex = 4;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.Controls.Add(this.banksFrame);
            this.splitContainer1.Panel1.Controls.Add(this.revenueFrame);
            this.splitContainer1.Panel1.Controls.Add(this.bucketsFrame);
            this.splitContainer1.Panel1.Controls.Add(this.expenseFrame);
            this.splitContainer1.Panel1.Controls.Add(this.budgetsFrame);
            this.splitContainer1.Size = new System.Drawing.Size(1230, 582);
            this.splitContainer1.SplitterDistance = 592;
            this.splitContainer1.TabIndex = 16;
            // 
            // SummaryFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "SummaryFrame";
            this.Size = new System.Drawing.Size(1230, 582);
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private BanksFrame banksFrame;
        private BucketsFrame bucketsFrame;
        private BudgetsFrame budgetsFrame;
        private ExpenseFrame expenseFrame;
        private RevenueFrame revenueFrame;
        private System.Windows.Forms.SplitContainer splitContainer1;


    }
}
