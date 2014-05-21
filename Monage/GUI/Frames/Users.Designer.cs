namespace Monage.GUI.Frames {
    partial class Users {
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
            this.cbxUsers = new System.Windows.Forms.ComboBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnRename = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbxUsers
            // 
            this.cbxUsers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxUsers.FormattingEnabled = true;
            this.cbxUsers.Location = new System.Drawing.Point(3, 30);
            this.cbxUsers.Name = "cbxUsers";
            this.cbxUsers.Size = new System.Drawing.Size(255, 30);
            this.cbxUsers.TabIndex = 0;
            // 
            // btnOpen
            // 
            this.btnOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpen.Location = new System.Drawing.Point(3, 66);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(81, 30);
            this.btnOpen.TabIndex = 7;
            this.btnOpen.Text = "&Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnRename
            // 
            this.btnRename.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRename.Location = new System.Drawing.Point(177, 66);
            this.btnRename.Name = "btnRename";
            this.btnRename.Size = new System.Drawing.Size(81, 30);
            this.btnRename.TabIndex = 6;
            this.btnRename.Text = "&Rename";
            this.btnRename.UseVisualStyleBackColor = true;
            this.btnRename.Click += new System.EventHandler(this.btnRename_Click);
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(90, 66);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(81, 30);
            this.btnNew.TabIndex = 5;
            this.btnNew.Text = "&New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "User Login";
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btnRename);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.cbxUsers);
            this.Name = "Users";
            this.Size = new System.Drawing.Size(261, 99);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxUsers;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnRename;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Label label1;
    }
}
