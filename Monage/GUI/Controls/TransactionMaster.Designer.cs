namespace Monage.GUI.Controls {
    partial class TransactionMaster {
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
            this.lblBrief = new System.Windows.Forms.Label();
            this.lblIncurred = new System.Windows.Forms.Label();
            this.lblConfirmed = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.lblAfter = new System.Windows.Forms.Label();
            this.lblBefore = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblBrief
            // 
            this.lblBrief.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrief.Location = new System.Drawing.Point(3, 0);
            this.lblBrief.Margin = new System.Windows.Forms.Padding(3);
            this.lblBrief.Name = "lblBrief";
            this.lblBrief.Size = new System.Drawing.Size(424, 30);
            this.lblBrief.TabIndex = 1;
            this.lblBrief.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblIncurred
            // 
            this.lblIncurred.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIncurred.Location = new System.Drawing.Point(433, 0);
            this.lblIncurred.Margin = new System.Windows.Forms.Padding(3);
            this.lblIncurred.Name = "lblIncurred";
            this.lblIncurred.Size = new System.Drawing.Size(94, 30);
            this.lblIncurred.TabIndex = 2;
            this.lblIncurred.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblConfirmed
            // 
            this.lblConfirmed.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmed.Location = new System.Drawing.Point(533, 0);
            this.lblConfirmed.Margin = new System.Windows.Forms.Padding(3);
            this.lblConfirmed.Name = "lblConfirmed";
            this.lblConfirmed.Size = new System.Drawing.Size(94, 30);
            this.lblConfirmed.TabIndex = 3;
            this.lblConfirmed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotal
            // 
            this.lblTotal.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(633, 0);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(3);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(140, 30);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Snow;
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.Blue;
            this.btnEdit.Image = global::Monage.Properties.Resources.IconPencil;
            this.btnEdit.Location = new System.Drawing.Point(1071, 3);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(26, 26);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // lblAfter
            // 
            this.lblAfter.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAfter.Location = new System.Drawing.Point(925, 0);
            this.lblAfter.Margin = new System.Windows.Forms.Padding(3);
            this.lblAfter.Name = "lblAfter";
            this.lblAfter.Size = new System.Drawing.Size(140, 30);
            this.lblAfter.TabIndex = 6;
            this.lblAfter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblBefore
            // 
            this.lblBefore.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBefore.Location = new System.Drawing.Point(779, 0);
            this.lblBefore.Margin = new System.Windows.Forms.Padding(3);
            this.lblBefore.Name = "lblBefore";
            this.lblBefore.Size = new System.Drawing.Size(140, 30);
            this.lblBefore.TabIndex = 7;
            this.lblBefore.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TransactionMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblBefore);
            this.Controls.Add(this.lblAfter);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblConfirmed);
            this.Controls.Add(this.lblIncurred);
            this.Controls.Add(this.lblBrief);
            this.Name = "TransactionMaster";
            this.Size = new System.Drawing.Size(1100, 32);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblBrief;
        private System.Windows.Forms.Label lblIncurred;
        private System.Windows.Forms.Label lblConfirmed;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label lblAfter;
        private System.Windows.Forms.Label lblBefore;
    }
}
