namespace Monage.GUI.Dialogs {
    partial class CreditDialog {
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRevenue = new System.Windows.Forms.RadioButton();
            this.btnBank = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.RevenueSource = new System.Windows.Forms.ComboBox();
            this.BankSource = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Amount = new System.Windows.Forms.NumericUpDown();
            this.Bucket = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Amount)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(165, 131);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(76, 28);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(83, 131);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(76, 28);
            this.btnOk.TabIndex = 6;
            this.btnOk.Text = "&Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Source";
            // 
            // btnRevenue
            // 
            this.btnRevenue.AutoSize = true;
            this.btnRevenue.Checked = true;
            this.btnRevenue.Location = new System.Drawing.Point(83, 7);
            this.btnRevenue.Name = "btnRevenue";
            this.btnRevenue.Size = new System.Drawing.Size(86, 21);
            this.btnRevenue.TabIndex = 1;
            this.btnRevenue.TabStop = true;
            this.btnRevenue.Text = "Revenue";
            this.btnRevenue.UseVisualStyleBackColor = true;
            // 
            // btnBank
            // 
            this.btnBank.AutoSize = true;
            this.btnBank.Location = new System.Drawing.Point(180, 7);
            this.btnBank.Name = "btnBank";
            this.btnBank.Size = new System.Drawing.Size(61, 21);
            this.btnBank.TabIndex = 2;
            this.btnBank.Text = "Bank";
            this.btnBank.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Account";
            // 
            // RevenueSource
            // 
            this.RevenueSource.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RevenueSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RevenueSource.FormattingEnabled = true;
            this.RevenueSource.Items.AddRange(new object[] {
            "Expense",
            "Bank Account"});
            this.RevenueSource.Location = new System.Drawing.Point(83, 34);
            this.RevenueSource.Name = "RevenueSource";
            this.RevenueSource.Size = new System.Drawing.Size(158, 26);
            this.RevenueSource.TabIndex = 4;
            // 
            // BankSource
            // 
            this.BankSource.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BankSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BankSource.FormattingEnabled = true;
            this.BankSource.Items.AddRange(new object[] {
            "Expense",
            "Bank Account"});
            this.BankSource.Location = new System.Drawing.Point(83, 34);
            this.BankSource.Name = "BankSource";
            this.BankSource.Size = new System.Drawing.Size(158, 26);
            this.BankSource.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Amount";
            // 
            // Amount
            // 
            this.Amount.DecimalPlaces = 2;
            this.Amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Amount.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.Amount.InterceptArrowKeys = false;
            this.Amount.Location = new System.Drawing.Point(83, 98);
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(158, 27);
            this.Amount.TabIndex = 5;
            this.Amount.ThousandsSeparator = true;
            // 
            // Bucket
            // 
            this.Bucket.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Bucket.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bucket.FormattingEnabled = true;
            this.Bucket.Items.AddRange(new object[] {
            "Expense",
            "Bank Account"});
            this.Bucket.Location = new System.Drawing.Point(83, 66);
            this.Bucket.Name = "Bucket";
            this.Bucket.Size = new System.Drawing.Size(158, 26);
            this.Bucket.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Bucket";
            // 
            // CreditDialog
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(253, 171);
            this.Controls.Add(this.Bucket);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Amount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.RevenueSource);
            this.Controls.Add(this.BankSource);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBank);
            this.Controls.Add(this.btnRevenue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = global::Monage.Properties.Resources.favicon;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreditDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Credit Ticket";
            ((System.ComponentModel.ISupportInitialize)(this.Amount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton btnRevenue;
        private System.Windows.Forms.RadioButton btnBank;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox RevenueSource;
        private System.Windows.Forms.ComboBox BankSource;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown Amount;
        private System.Windows.Forms.ComboBox Bucket;
        private System.Windows.Forms.Label label3;
    }
}