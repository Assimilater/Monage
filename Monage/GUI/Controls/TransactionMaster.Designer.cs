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
            this.lblConfirmed = new System.Windows.Forms.Label();
            this.lblAfter = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.pnlIndent = new System.Windows.Forms.Panel();
            this.pnlRow = new System.Windows.Forms.Panel();
            this.lblIncurred = new System.Windows.Forms.Label();
            this.btnExpand = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.pnlExpanded = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.pnlOverflow = new System.Windows.Forms.Panel();
            this.lblDetails = new System.Windows.Forms.Label();
            this.pnlRow.SuspendLayout();
            this.pnlExpanded.SuspendLayout();
            this.pnlOverflow.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBrief
            // 
            this.lblBrief.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBrief.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrief.Location = new System.Drawing.Point(191, -1);
            this.lblBrief.Margin = new System.Windows.Forms.Padding(3);
            this.lblBrief.Name = "lblBrief";
            this.lblBrief.Size = new System.Drawing.Size(429, 34);
            this.lblBrief.TabIndex = 1;
            this.lblBrief.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblConfirmed
            // 
            this.lblConfirmed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblConfirmed.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmed.Location = new System.Drawing.Point(95, -1);
            this.lblConfirmed.Margin = new System.Windows.Forms.Padding(3);
            this.lblConfirmed.Name = "lblConfirmed";
            this.lblConfirmed.Size = new System.Drawing.Size(97, 34);
            this.lblConfirmed.TabIndex = 3;
            this.lblConfirmed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAfter
            // 
            this.lblAfter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAfter.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAfter.Location = new System.Drawing.Point(758, -1);
            this.lblAfter.Margin = new System.Windows.Forms.Padding(3);
            this.lblAfter.Name = "lblAfter";
            this.lblAfter.Size = new System.Drawing.Size(140, 34);
            this.lblAfter.TabIndex = 6;
            this.lblAfter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAmount
            // 
            this.lblAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAmount.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(619, -1);
            this.lblAmount.Margin = new System.Windows.Forms.Padding(3);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(140, 34);
            this.lblAmount.TabIndex = 7;
            this.lblAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlIndent
            // 
            this.pnlIndent.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlIndent.Location = new System.Drawing.Point(0, 33);
            this.pnlIndent.Name = "pnlIndent";
            this.pnlIndent.Size = new System.Drawing.Size(150, 442);
            this.pnlIndent.TabIndex = 10;
            // 
            // pnlRow
            // 
            this.pnlRow.Controls.Add(this.lblIncurred);
            this.pnlRow.Controls.Add(this.btnExpand);
            this.pnlRow.Controls.Add(this.lblConfirmed);
            this.pnlRow.Controls.Add(this.lblAmount);
            this.pnlRow.Controls.Add(this.btnEdit);
            this.pnlRow.Controls.Add(this.lblAfter);
            this.pnlRow.Controls.Add(this.lblBrief);
            this.pnlRow.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlRow.Location = new System.Drawing.Point(0, 0);
            this.pnlRow.Name = "pnlRow";
            this.pnlRow.Size = new System.Drawing.Size(961, 33);
            this.pnlRow.TabIndex = 11;
            // 
            // lblIncurred
            // 
            this.lblIncurred.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblIncurred.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIncurred.Location = new System.Drawing.Point(-1, -1);
            this.lblIncurred.Margin = new System.Windows.Forms.Padding(3);
            this.lblIncurred.Name = "lblIncurred";
            this.lblIncurred.Size = new System.Drawing.Size(97, 34);
            this.lblIncurred.TabIndex = 9;
            this.lblIncurred.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnExpand
            // 
            this.btnExpand.BackColor = System.Drawing.Color.Snow;
            this.btnExpand.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExpand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExpand.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpand.ForeColor = System.Drawing.Color.Blue;
            this.btnExpand.Image = global::Monage.Properties.Resources.IconPlus;
            this.btnExpand.Location = new System.Drawing.Point(930, 3);
            this.btnExpand.Name = "btnExpand";
            this.btnExpand.Size = new System.Drawing.Size(26, 26);
            this.btnExpand.TabIndex = 8;
            this.btnExpand.UseVisualStyleBackColor = false;
            this.btnExpand.Click += new System.EventHandler(this.btnExpand_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Snow;
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.Blue;
            this.btnEdit.Image = global::Monage.Properties.Resources.IconPencil;
            this.btnEdit.Location = new System.Drawing.Point(901, 3);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(26, 26);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // pnlExpanded
            // 
            this.pnlExpanded.Controls.Add(this.label12);
            this.pnlExpanded.Controls.Add(this.pnlOverflow);
            this.pnlExpanded.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlExpanded.Location = new System.Drawing.Point(150, 33);
            this.pnlExpanded.Name = "pnlExpanded";
            this.pnlExpanded.Size = new System.Drawing.Size(811, 442);
            this.pnlExpanded.TabIndex = 11;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 6);
            this.label12.Margin = new System.Windows.Forms.Padding(3, 3, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 17);
            this.label12.TabIndex = 22;
            this.label12.Text = "Notes:";
            // 
            // pnlOverflow
            // 
            this.pnlOverflow.AutoScroll = true;
            this.pnlOverflow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlOverflow.Controls.Add(this.lblDetails);
            this.pnlOverflow.Location = new System.Drawing.Point(6, 23);
            this.pnlOverflow.Name = "pnlOverflow";
            this.pnlOverflow.Size = new System.Drawing.Size(802, 160);
            this.pnlOverflow.TabIndex = 23;
            // 
            // lblDetails
            // 
            this.lblDetails.AutoSize = true;
            this.lblDetails.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetails.Location = new System.Drawing.Point(0, 0);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(250, 23);
            this.lblDetails.TabIndex = 10;
            this.lblDetails.Text = "This transaction\'s notes go here";
            // 
            // TransactionMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.pnlExpanded);
            this.Controls.Add(this.pnlIndent);
            this.Controls.Add(this.pnlRow);
            this.Name = "TransactionMaster";
            this.Size = new System.Drawing.Size(961, 475);
            this.pnlRow.ResumeLayout(false);
            this.pnlExpanded.ResumeLayout(false);
            this.pnlExpanded.PerformLayout();
            this.pnlOverflow.ResumeLayout(false);
            this.pnlOverflow.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblBrief;
        private System.Windows.Forms.Label lblConfirmed;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label lblAfter;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Button btnExpand;
        private System.Windows.Forms.Panel pnlIndent;
        private System.Windows.Forms.Panel pnlRow;
        private System.Windows.Forms.Panel pnlExpanded;
        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel pnlOverflow;
        private System.Windows.Forms.Label lblIncurred;
    }
}
