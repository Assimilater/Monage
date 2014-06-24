namespace Monage.GUI.Frames {
    partial class TransactionFrame {
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
            this.txtDetails = new System.Windows.Forms.TextBox();
            this.cbxCreditType = new System.Windows.Forms.ComboBox();
            this.dtConfirm = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtRecord = new System.Windows.Forms.DateTimePicker();
            this.cbxBanks = new System.Windows.Forms.ComboBox();
            this.cbxExpense = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtDetails
            // 
            this.txtDetails.Location = new System.Drawing.Point(3, 305);
            this.txtDetails.Multiline = true;
            this.txtDetails.Name = "txtDetails";
            this.txtDetails.Size = new System.Drawing.Size(558, 122);
            this.txtDetails.TabIndex = 1;
            // 
            // cbxCreditType
            // 
            this.cbxCreditType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCreditType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCreditType.FormattingEnabled = true;
            this.cbxCreditType.Items.AddRange(new object[] {
            "Expense",
            "Bank Account"});
            this.cbxCreditType.Location = new System.Drawing.Point(3, 3);
            this.cbxCreditType.Name = "cbxCreditType";
            this.cbxCreditType.Size = new System.Drawing.Size(232, 26);
            this.cbxCreditType.TabIndex = 2;
            // 
            // dtConfirm
            // 
            this.dtConfirm.CustomFormat = "  MM/dd/yyyy";
            this.dtConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtConfirm.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtConfirm.Location = new System.Drawing.Point(328, 275);
            this.dtConfirm.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dtConfirm.Name = "dtConfirm";
            this.dtConfirm.ShowCheckBox = true;
            this.dtConfirm.Size = new System.Drawing.Size(153, 24);
            this.dtConfirm.TabIndex = 3;
            this.dtConfirm.Value = new System.DateTime(2014, 6, 23, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(247, 278);
            this.label1.Margin = new System.Windows.Forms.Padding(9, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Confirmed:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 278);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Recorded:";
            // 
            // dtRecord
            // 
            this.dtRecord.CustomFormat = "  MM/dd/yyyy";
            this.dtRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtRecord.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtRecord.Location = new System.Drawing.Point(82, 275);
            this.dtRecord.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dtRecord.Name = "dtRecord";
            this.dtRecord.Size = new System.Drawing.Size(153, 24);
            this.dtRecord.TabIndex = 6;
            this.dtRecord.Value = new System.DateTime(2014, 6, 23, 0, 0, 0, 0);
            // 
            // cbxBanks
            // 
            this.cbxBanks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxBanks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxBanks.FormattingEnabled = true;
            this.cbxBanks.Items.AddRange(new object[] {
            "Expense",
            "Bank Account"});
            this.cbxBanks.Location = new System.Drawing.Point(241, 3);
            this.cbxBanks.Name = "cbxBanks";
            this.cbxBanks.Size = new System.Drawing.Size(232, 26);
            this.cbxBanks.TabIndex = 8;
            // 
            // cbxExpense
            // 
            this.cbxExpense.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxExpense.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxExpense.FormattingEnabled = true;
            this.cbxExpense.Items.AddRange(new object[] {
            "Expense",
            "Bank Account"});
            this.cbxExpense.Location = new System.Drawing.Point(241, 3);
            this.cbxExpense.Name = "cbxExpense";
            this.cbxExpense.Size = new System.Drawing.Size(232, 26);
            this.cbxExpense.TabIndex = 9;
            // 
            // TransactionFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbxExpense);
            this.Controls.Add(this.cbxBanks);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtRecord);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtConfirm);
            this.Controls.Add(this.cbxCreditType);
            this.Controls.Add(this.txtDetails);
            this.Name = "TransactionFrame";
            this.Size = new System.Drawing.Size(564, 430);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDetails;
        private System.Windows.Forms.ComboBox cbxCreditType;
        private System.Windows.Forms.DateTimePicker dtConfirm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtRecord;
        private System.Windows.Forms.ComboBox cbxBanks;
        private System.Windows.Forms.ComboBox cbxExpense;
    }
}
