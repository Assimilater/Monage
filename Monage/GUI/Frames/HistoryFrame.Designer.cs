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
            this.label2 = new System.Windows.Forms.Label();
            this.dtEnd = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtStart = new System.Windows.Forms.DateTimePicker();
            this.lblSort = new System.Windows.Forms.Label();
            this.rdbConfirmed = new System.Windows.Forms.RadioButton();
            this.rdbIncurred = new System.Windows.Forms.RadioButton();
            this.cbxBuckets = new System.Windows.Forms.ComboBox();
            this.cbxBanks = new System.Windows.Forms.ComboBox();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblBrief = new System.Windows.Forms.Label();
            this.lblConfirmed = new System.Windows.Forms.Label();
            this.lblIncurred = new System.Windows.Forms.Label();
            this.lblCashflow = new System.Windows.Forms.Label();
            this.pnlTransactions = new System.Windows.Forms.Panel();
            this.pnlFilter.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFilter
            // 
            this.pnlFilter.Controls.Add(this.label2);
            this.pnlFilter.Controls.Add(this.dtEnd);
            this.pnlFilter.Controls.Add(this.label1);
            this.pnlFilter.Controls.Add(this.dtStart);
            this.pnlFilter.Controls.Add(this.lblSort);
            this.pnlFilter.Controls.Add(this.rdbConfirmed);
            this.pnlFilter.Controls.Add(this.rdbIncurred);
            this.pnlFilter.Controls.Add(this.cbxBuckets);
            this.pnlFilter.Controls.Add(this.cbxBanks);
            this.pnlFilter.Controls.Add(this.pnlHeader);
            this.pnlFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFilter.Location = new System.Drawing.Point(0, 0);
            this.pnlFilter.Name = "pnlFilter";
            this.pnlFilter.Size = new System.Drawing.Size(1014, 58);
            this.pnlFilter.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(604, 8);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 3, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 17);
            this.label2.TabIndex = 25;
            this.label2.Text = "To:";
            // 
            // dtEnd
            // 
            this.dtEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtEnd.Location = new System.Drawing.Point(638, 5);
            this.dtEnd.MinDate = new System.DateTime(2014, 1, 1, 0, 0, 0, 0);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.Size = new System.Drawing.Size(123, 24);
            this.dtEnd.TabIndex = 3;
            this.dtEnd.Value = new System.DateTime(2014, 1, 1, 0, 0, 0, 0);
            this.dtEnd.ValueChanged += new System.EventHandler(this.UpdateFilters);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(423, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 3, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 23;
            this.label1.Text = "From:";
            // 
            // dtStart
            // 
            this.dtStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtStart.Location = new System.Drawing.Point(472, 5);
            this.dtStart.MinDate = new System.DateTime(2014, 1, 1, 0, 0, 0, 0);
            this.dtStart.Name = "dtStart";
            this.dtStart.Size = new System.Drawing.Size(123, 24);
            this.dtStart.TabIndex = 2;
            this.dtStart.Value = new System.DateTime(2014, 1, 1, 0, 0, 0, 0);
            this.dtStart.ValueChanged += new System.EventHandler(this.UpdateFilters);
            // 
            // lblSort
            // 
            this.lblSort.AutoSize = true;
            this.lblSort.Location = new System.Drawing.Point(767, 8);
            this.lblSort.Margin = new System.Windows.Forms.Padding(3, 3, 2, 0);
            this.lblSort.Name = "lblSort";
            this.lblSort.Size = new System.Drawing.Size(58, 17);
            this.lblSort.TabIndex = 21;
            this.lblSort.Text = "Sort By:";
            // 
            // rdbConfirmed
            // 
            this.rdbConfirmed.AutoSize = true;
            this.rdbConfirmed.Location = new System.Drawing.Point(917, 6);
            this.rdbConfirmed.Name = "rdbConfirmed";
            this.rdbConfirmed.Size = new System.Drawing.Size(93, 21);
            this.rdbConfirmed.TabIndex = 5;
            this.rdbConfirmed.Text = "Confirmed";
            this.rdbConfirmed.UseVisualStyleBackColor = true;
            this.rdbConfirmed.Click += new System.EventHandler(this.UpdateFilters);
            // 
            // rdbIncurred
            // 
            this.rdbIncurred.AutoSize = true;
            this.rdbIncurred.Checked = true;
            this.rdbIncurred.Location = new System.Drawing.Point(830, 6);
            this.rdbIncurred.Name = "rdbIncurred";
            this.rdbIncurred.Size = new System.Drawing.Size(81, 21);
            this.rdbIncurred.TabIndex = 4;
            this.rdbIncurred.TabStop = true;
            this.rdbIncurred.Text = "Incurred";
            this.rdbIncurred.UseVisualStyleBackColor = true;
            this.rdbIncurred.Click += new System.EventHandler(this.UpdateFilters);
            // 
            // cbxBuckets
            // 
            this.cbxBuckets.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxBuckets.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxBuckets.FormattingEnabled = true;
            this.cbxBuckets.Location = new System.Drawing.Point(213, 3);
            this.cbxBuckets.Name = "cbxBuckets";
            this.cbxBuckets.Size = new System.Drawing.Size(204, 26);
            this.cbxBuckets.TabIndex = 1;
            this.cbxBuckets.SelectedIndexChanged += new System.EventHandler(this.UpdateFilters);
            // 
            // cbxBanks
            // 
            this.cbxBanks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxBanks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxBanks.FormattingEnabled = true;
            this.cbxBanks.Location = new System.Drawing.Point(3, 3);
            this.cbxBanks.Name = "cbxBanks";
            this.cbxBanks.Size = new System.Drawing.Size(204, 26);
            this.cbxBanks.TabIndex = 0;
            this.cbxBanks.SelectedIndexChanged += new System.EventHandler(this.UpdateFilters);
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.lblBalance);
            this.pnlHeader.Controls.Add(this.lblAmount);
            this.pnlHeader.Controls.Add(this.lblBrief);
            this.pnlHeader.Controls.Add(this.lblConfirmed);
            this.pnlHeader.Controls.Add(this.lblIncurred);
            this.pnlHeader.Controls.Add(this.lblCashflow);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlHeader.Location = new System.Drawing.Point(0, 33);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1014, 25);
            this.pnlHeader.TabIndex = 3;
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.Location = new System.Drawing.Point(760, 3);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(59, 20);
            this.lblBalance.TabIndex = 4;
            this.lblBalance.Text = "Balance";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(621, 3);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(65, 20);
            this.lblAmount.TabIndex = 3;
            this.lblAmount.Text = "Amount";
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
            // lblCashflow
            // 
            this.lblCashflow.AutoSize = true;
            this.lblCashflow.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCashflow.Location = new System.Drawing.Point(760, 3);
            this.lblCashflow.Name = "lblCashflow";
            this.lblCashflow.Size = new System.Drawing.Size(71, 20);
            this.lblCashflow.TabIndex = 5;
            this.lblCashflow.Text = "Cashflow";
            // 
            // pnlTransactions
            // 
            this.pnlTransactions.AutoScroll = true;
            this.pnlTransactions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTransactions.Location = new System.Drawing.Point(0, 58);
            this.pnlTransactions.Name = "pnlTransactions";
            this.pnlTransactions.Size = new System.Drawing.Size(1014, 507);
            this.pnlTransactions.TabIndex = 0;
            // 
            // HistoryFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlTransactions);
            this.Controls.Add(this.pnlFilter);
            this.Name = "HistoryFrame";
            this.Size = new System.Drawing.Size(1014, 565);
            this.pnlFilter.ResumeLayout(false);
            this.pnlFilter.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFilter;
        private System.Windows.Forms.Panel pnlTransactions;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblBrief;
        private System.Windows.Forms.Label lblConfirmed;
        private System.Windows.Forms.Label lblIncurred;
        private System.Windows.Forms.ComboBox cbxBuckets;
        private System.Windows.Forms.ComboBox cbxBanks;
        private System.Windows.Forms.Label lblSort;
        private System.Windows.Forms.RadioButton rdbConfirmed;
        private System.Windows.Forms.RadioButton rdbIncurred;
        private System.Windows.Forms.Label lblCashflow;
        private System.Windows.Forms.DateTimePicker dtStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtEnd;
        private System.Windows.Forms.Label label1;
    }
}
