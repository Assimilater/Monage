namespace Monage.GUI.Controls {
    partial class TicketMaster {
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
            this.lblCredit = new System.Windows.Forms.Label();
            this.lblDebitAmount = new System.Windows.Forms.Label();
            this.lblCreditAmount = new System.Windows.Forms.Label();
            this.lblDebit = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCredit
            // 
            this.lblCredit.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCredit.Location = new System.Drawing.Point(127, 3);
            this.lblCredit.Margin = new System.Windows.Forms.Padding(3);
            this.lblCredit.Name = "lblCredit";
            this.lblCredit.Size = new System.Drawing.Size(325, 26);
            this.lblCredit.TabIndex = 0;
            // 
            // lblDebitAmount
            // 
            this.lblDebitAmount.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDebitAmount.Location = new System.Drawing.Point(631, 3);
            this.lblDebitAmount.Margin = new System.Windows.Forms.Padding(3);
            this.lblDebitAmount.Name = "lblDebitAmount";
            this.lblDebitAmount.Size = new System.Drawing.Size(167, 26);
            this.lblDebitAmount.TabIndex = 1;
            this.lblDebitAmount.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblCreditAmount
            // 
            this.lblCreditAmount.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreditAmount.Location = new System.Drawing.Point(458, 3);
            this.lblCreditAmount.Margin = new System.Windows.Forms.Padding(3);
            this.lblCreditAmount.Name = "lblCreditAmount";
            this.lblCreditAmount.Size = new System.Drawing.Size(167, 26);
            this.lblCreditAmount.TabIndex = 2;
            this.lblCreditAmount.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblDebit
            // 
            this.lblDebit.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDebit.Location = new System.Drawing.Point(55, 3);
            this.lblDebit.Margin = new System.Windows.Forms.Padding(3);
            this.lblDebit.Name = "lblDebit";
            this.lblDebit.Size = new System.Drawing.Size(397, 26);
            this.lblDebit.TabIndex = 3;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Snow;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Red;
            this.btnDelete.Location = new System.Drawing.Point(3, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(26, 26);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "X";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // TicketMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblCreditAmount);
            this.Controls.Add(this.lblDebitAmount);
            this.Controls.Add(this.lblCredit);
            this.Controls.Add(this.lblDebit);
            this.Name = "TicketMaster";
            this.Size = new System.Drawing.Size(801, 32);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCredit;
        private System.Windows.Forms.Label lblDebitAmount;
        private System.Windows.Forms.Label lblCreditAmount;
        private System.Windows.Forms.Label lblDebit;
        private System.Windows.Forms.Button btnDelete;
    }
}
