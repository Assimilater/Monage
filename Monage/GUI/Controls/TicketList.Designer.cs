namespace Monage.GUI.Controls {
    partial class TicketList {
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
            this.lblTickets = new System.Windows.Forms.GroupBox();
            this.pnlTickets = new System.Windows.Forms.Panel();
            this.lblTickets.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTickets
            // 
            this.lblTickets.Controls.Add(this.pnlTickets);
            this.lblTickets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTickets.Location = new System.Drawing.Point(0, 0);
            this.lblTickets.Name = "lblTickets";
            this.lblTickets.Size = new System.Drawing.Size(860, 251);
            this.lblTickets.TabIndex = 28;
            this.lblTickets.TabStop = false;
            this.lblTickets.Text = "Tickets";
            // 
            // pnlTickets
            // 
            this.pnlTickets.AutoScroll = true;
            this.pnlTickets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlTickets.Location = new System.Drawing.Point(3, 23);
            this.pnlTickets.Name = "pnlTickets";
            this.pnlTickets.Size = new System.Drawing.Size(854, 225);
            this.pnlTickets.TabIndex = 0;
            // 
            // TicketList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblTickets);
            this.Name = "TicketList";
            this.Size = new System.Drawing.Size(860, 251);
            this.lblTickets.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox lblTickets;
        private System.Windows.Forms.Panel pnlTickets;
    }
}
