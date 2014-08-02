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
            this.btnExpand = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBrief
            // 
            this.lblBrief.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrief.Location = new System.Drawing.Point(0, 0);
            this.lblBrief.Margin = new System.Windows.Forms.Padding(3);
            this.lblBrief.Name = "lblBrief";
            this.lblBrief.Size = new System.Drawing.Size(417, 30);
            this.lblBrief.TabIndex = 1;
            this.lblBrief.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblIncurred
            // 
            this.lblIncurred.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIncurred.Location = new System.Drawing.Point(423, 0);
            this.lblIncurred.Margin = new System.Windows.Forms.Padding(3);
            this.lblIncurred.Name = "lblIncurred";
            this.lblIncurred.Size = new System.Drawing.Size(94, 30);
            this.lblIncurred.TabIndex = 2;
            this.lblIncurred.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblConfirmed
            // 
            this.lblConfirmed.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmed.Location = new System.Drawing.Point(523, 0);
            this.lblConfirmed.Margin = new System.Windows.Forms.Padding(3);
            this.lblConfirmed.Name = "lblConfirmed";
            this.lblConfirmed.Size = new System.Drawing.Size(94, 30);
            this.lblConfirmed.TabIndex = 3;
            this.lblConfirmed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotal
            // 
            this.lblTotal.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(623, 0);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(3);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(143, 30);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnExpand
            // 
            this.btnExpand.BackColor = System.Drawing.Color.Snow;
            this.btnExpand.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExpand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExpand.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpand.ForeColor = System.Drawing.Color.Blue;
            this.btnExpand.Image = global::Monage.Properties.Resources.IconPlus;
            this.btnExpand.Location = new System.Drawing.Point(772, 3);
            this.btnExpand.Name = "btnExpand";
            this.btnExpand.Size = new System.Drawing.Size(26, 26);
            this.btnExpand.TabIndex = 5;
            this.btnExpand.UseVisualStyleBackColor = false;
            // 
            // TransactionMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnExpand);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblConfirmed);
            this.Controls.Add(this.lblIncurred);
            this.Controls.Add(this.lblBrief);
            this.Name = "TransactionMaster";
            this.Size = new System.Drawing.Size(801, 32);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblBrief;
        private System.Windows.Forms.Label lblIncurred;
        private System.Windows.Forms.Label lblConfirmed;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnExpand;
    }
}
