namespace Monage.GUI.Frames {
    partial class HistoryFrame {
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
            this.pnlFilter = new System.Windows.Forms.Panel();
            this.pnlTransactions = new System.Windows.Forms.Panel();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblAfter = new System.Windows.Forms.Label();
            this.lblBefore = new System.Windows.Forms.Label();
            this.lblBrief = new System.Windows.Forms.Label();
            this.lblConfirmed = new System.Windows.Forms.Label();
            this.lblIncurred = new System.Windows.Forms.Label();
            this.pnlFilter.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFilter
            // 
            this.pnlFilter.Controls.Add(this.pnlHeader);
            this.pnlFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFilter.Location = new System.Drawing.Point(0, 0);
            this.pnlFilter.Name = "pnlFilter";
            this.pnlFilter.Size = new System.Drawing.Size(985, 75);
            this.pnlFilter.TabIndex = 0;
            // 
            // pnlTransactions
            // 
            this.pnlTransactions.AutoScroll = true;
            this.pnlTransactions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTransactions.Location = new System.Drawing.Point(0, 75);
            this.pnlTransactions.Name = "pnlTransactions";
            this.pnlTransactions.Size = new System.Drawing.Size(985, 527);
            this.pnlTransactions.TabIndex = 1;
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.lblAfter);
            this.pnlHeader.Controls.Add(this.lblBefore);
            this.pnlHeader.Controls.Add(this.lblBrief);
            this.pnlHeader.Controls.Add(this.lblConfirmed);
            this.pnlHeader.Controls.Add(this.lblIncurred);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlHeader.Location = new System.Drawing.Point(0, 50);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(985, 25);
            this.pnlHeader.TabIndex = 3;
            // 
            // lblAfter
            // 
            this.lblAfter.AutoSize = true;
            this.lblAfter.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAfter.Location = new System.Drawing.Point(760, 3);
            this.lblAfter.Name = "lblAfter";
            this.lblAfter.Size = new System.Drawing.Size(43, 20);
            this.lblAfter.TabIndex = 4;
            this.lblAfter.Text = "After";
            // 
            // lblBefore
            // 
            this.lblBefore.AutoSize = true;
            this.lblBefore.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBefore.Location = new System.Drawing.Point(621, 3);
            this.lblBefore.Name = "lblBefore";
            this.lblBefore.Size = new System.Drawing.Size(51, 20);
            this.lblBefore.TabIndex = 3;
            this.lblBefore.Text = "Before";
            // 
            // lblBrief
            // 
            this.lblBrief.AutoSize = true;
            this.lblBrief.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrief.Location = new System.Drawing.Point(193, 3);
            this.lblBrief.Name = "lblBrief";
            this.lblBrief.Size = new System.Drawing.Size(40, 20);
            this.lblBrief.TabIndex = 2;
            this.lblBrief.Text = "Brief";
            // 
            // lblConfirmed
            // 
            this.lblConfirmed.AutoSize = true;
            this.lblConfirmed.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmed.Location = new System.Drawing.Point(97, 3);
            this.lblConfirmed.Name = "lblConfirmed";
            this.lblConfirmed.Size = new System.Drawing.Size(82, 20);
            this.lblConfirmed.TabIndex = 1;
            this.lblConfirmed.Text = "Confirmed";
            // 
            // lblIncurred
            // 
            this.lblIncurred.AutoSize = true;
            this.lblIncurred.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIncurred.Location = new System.Drawing.Point(2, 3);
            this.lblIncurred.Name = "lblIncurred";
            this.lblIncurred.Size = new System.Drawing.Size(67, 20);
            this.lblIncurred.TabIndex = 0;
            this.lblIncurred.Text = "Incurred";
            // 
            // HistoryFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlTransactions);
            this.Controls.Add(this.pnlFilter);
            this.Name = "HistoryFrame";
            this.Size = new System.Drawing.Size(985, 602);
            this.pnlFilter.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFilter;
        private System.Windows.Forms.Panel pnlTransactions;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblAfter;
        private System.Windows.Forms.Label lblBefore;
        private System.Windows.Forms.Label lblBrief;
        private System.Windows.Forms.Label lblConfirmed;
        private System.Windows.Forms.Label lblIncurred;
    }
}
