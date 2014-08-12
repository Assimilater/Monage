namespace Monage.GUI.Dialogs {
    partial class AmountDialog {
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
            this.lblPrompt = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.numAmount = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPrompt
            // 
            this.lblPrompt.AutoSize = true;
            this.lblPrompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrompt.Location = new System.Drawing.Point(12, 9);
            this.lblPrompt.Name = "lblPrompt";
            this.lblPrompt.Size = new System.Drawing.Size(156, 18);
            this.lblPrompt.TabIndex = 0;
            this.lblPrompt.Text = "Enter the new amount:";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(255, 30);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(76, 28);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(173, 30);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(76, 28);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "&Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // numAmount
            // 
            this.numAmount.DecimalPlaces = 2;
            this.numAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numAmount.Location = new System.Drawing.Point(12, 31);
            this.numAmount.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numAmount.Minimum = new decimal(new int[] {
            1000000000,
            0,
            0,
            -2147483648});
            this.numAmount.Name = "numAmount";
            this.numAmount.Size = new System.Drawing.Size(155, 27);
            this.numAmount.TabIndex = 4;
            this.numAmount.ThousandsSeparator = true;
            // 
            // AmountDialog
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(343, 70);
            this.Controls.Add(this.numAmount);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblPrompt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = global::Monage.Properties.Resources.favicon;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(361, 115);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(361, 115);
            this.Name = "AmountDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Adjust Ticket Balance";
            ((System.ComponentModel.ISupportInitialize)(this.numAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrompt;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.NumericUpDown numAmount;
    }
}