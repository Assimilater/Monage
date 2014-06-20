namespace Monage.GUI.Frames.Controls {
    partial class BudgetListItem {
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
            this.refDelete = new System.Windows.Forms.Label();
            this.refRename = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // refDelete
            // 
            this.refDelete.AutoSize = true;
            this.refDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refDelete.ForeColor = System.Drawing.Color.Blue;
            this.refDelete.Location = new System.Drawing.Point(81, 29);
            this.refDelete.Name = "refDelete";
            this.refDelete.Size = new System.Drawing.Size(58, 20);
            this.refDelete.TabIndex = 8;
            this.refDelete.Text = "Delete";
            // 
            // refRename
            // 
            this.refRename.AutoSize = true;
            this.refRename.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refRename.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refRename.ForeColor = System.Drawing.Color.Blue;
            this.refRename.Location = new System.Drawing.Point(4, 29);
            this.refRename.Name = "refRename";
            this.refRename.Size = new System.Drawing.Size(71, 20);
            this.refRename.TabIndex = 7;
            this.refRename.Text = "Rename";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(3, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(78, 29);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Name";
            // 
            // BudgetListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.refDelete);
            this.Controls.Add(this.refRename);
            this.Controls.Add(this.lblName);
            this.Name = "BudgetListItem";
            this.Size = new System.Drawing.Size(275, 50);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label refDelete;
        private System.Windows.Forms.Label refRename;
        private System.Windows.Forms.Label lblName;
    }
}
