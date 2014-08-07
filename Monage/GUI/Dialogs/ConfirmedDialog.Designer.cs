namespace Monage.GUI.Dialogs {
    partial class ConfirmedDialog {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfirmedDialog));
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblPrompt = new System.Windows.Forms.Label();
            this.dtConfirm = new System.Windows.Forms.DateTimePicker();
            this.dtTime = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(288, 182);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(76, 28);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "&Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(370, 182);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(76, 28);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // lblPrompt
            // 
            this.lblPrompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrompt.Location = new System.Drawing.Point(12, 9);
            this.lblPrompt.Name = "lblPrompt";
            this.lblPrompt.Size = new System.Drawing.Size(434, 170);
            this.lblPrompt.TabIndex = 6;
            this.lblPrompt.Text = resources.GetString("lblPrompt.Text");
            // 
            // dtConfirm
            // 
            this.dtConfirm.CustomFormat = "MM/dd/yyyy";
            this.dtConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtConfirm.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtConfirm.Location = new System.Drawing.Point(12, 183);
            this.dtConfirm.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dtConfirm.Name = "dtConfirm";
            this.dtConfirm.Size = new System.Drawing.Size(132, 27);
            this.dtConfirm.TabIndex = 8;
            this.dtConfirm.Value = new System.DateTime(2014, 6, 23, 0, 0, 0, 0);
            this.dtConfirm.ValueChanged += new System.EventHandler(this.dtConfirm_ValueChanged);
            // 
            // dtTime
            // 
            this.dtTime.CustomFormat = "  MM/dd/yyyy";
            this.dtTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtTime.Location = new System.Drawing.Point(150, 183);
            this.dtTime.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dtTime.Name = "dtTime";
            this.dtTime.ShowUpDown = true;
            this.dtTime.Size = new System.Drawing.Size(132, 27);
            this.dtTime.TabIndex = 9;
            this.dtTime.Value = new System.DateTime(2014, 6, 23, 0, 0, 0, 0);
            this.dtTime.ValueChanged += new System.EventHandler(this.dtTime_ValueChanged);
            // 
            // ConfirmedDialog
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(458, 222);
            this.Controls.Add(this.dtTime);
            this.Controls.Add(this.dtConfirm);
            this.Controls.Add(this.lblPrompt);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = global::Monage.Properties.Resources.favicon;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConfirmedDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Bank Confirmation";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblPrompt;
        private System.Windows.Forms.DateTimePicker dtConfirm;
        private System.Windows.Forms.DateTimePicker dtTime;
    }
}