using Monage.GUI.Lists;
namespace Monage.GUI.Frames {
    partial class BankFrame {
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
            this.bucketsFrame = new Monage.GUI.Lists.BucketsList();
            this.banksFrame = new Monage.GUI.Lists.BanksList();
            this.pnlEditor = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // bucketsFrame
            // 
            this.bucketsFrame.AutoScroll = true;
            this.bucketsFrame.Dock = System.Windows.Forms.DockStyle.Left;
            this.bucketsFrame.Location = new System.Drawing.Point(306, 0);
            this.bucketsFrame.Name = "bucketsFrame";
            this.bucketsFrame.Size = new System.Drawing.Size(306, 582);
            this.bucketsFrame.TabIndex = 4;
            // 
            // banksFrame
            // 
            this.banksFrame.AutoScroll = true;
            this.banksFrame.Dock = System.Windows.Forms.DockStyle.Left;
            this.banksFrame.Location = new System.Drawing.Point(0, 0);
            this.banksFrame.Name = "banksFrame";
            this.banksFrame.Size = new System.Drawing.Size(306, 582);
            this.banksFrame.TabIndex = 3;
            // 
            // pnlEditor
            // 
            this.pnlEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEditor.Location = new System.Drawing.Point(612, 0);
            this.pnlEditor.Name = "pnlEditor";
            this.pnlEditor.Size = new System.Drawing.Size(458, 582);
            this.pnlEditor.TabIndex = 6;
            // 
            // AccountFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlEditor);
            this.Controls.Add(this.bucketsFrame);
            this.Controls.Add(this.banksFrame);
            this.Name = "AccountFrame";
            this.Size = new System.Drawing.Size(1070, 582);
            this.ResumeLayout(false);

        }

        #endregion

        private BucketsList bucketsFrame;
        private BanksList banksFrame;
        private System.Windows.Forms.Panel pnlEditor;


    }
}
