namespace Monage.GUI.Frames {
    partial class TransactionFrame {
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
            this.txtDetails = new System.Windows.Forms.TextBox();
            this.dtConfirm = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtRecord = new System.Windows.Forms.DateTimePicker();
            this.cbxBanks = new System.Windows.Forms.ComboBox();
            this.cbxExpenses = new System.Windows.Forms.ComboBox();
            this.cbxBuckets = new System.Windows.Forms.ComboBox();
            this.cbxRevenues = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBrief = new System.Windows.Forms.TextBox();
            this.cbxBudgets = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxAction = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnTicket = new System.Windows.Forms.Button();
            this.txtCompany = new System.Windows.Forms.TextBox();
            this.numAmount = new System.Windows.Forms.NumericUpDown();
            this.button2 = new System.Windows.Forms.Button();
            this.lblTickets = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.numAmount)).BeginInit();
            this.lblTickets.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDetails
            // 
            this.txtDetails.Location = new System.Drawing.Point(3, 174);
            this.txtDetails.Multiline = true;
            this.txtDetails.Name = "txtDetails";
            this.txtDetails.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDetails.Size = new System.Drawing.Size(471, 104);
            this.txtDetails.TabIndex = 1;
            this.txtDetails.TextChanged += new System.EventHandler(this.txtDetails_TextChanged);
            // 
            // dtConfirm
            // 
            this.dtConfirm.CustomFormat = "  MM/dd/yyyy";
            this.dtConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtConfirm.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtConfirm.Location = new System.Drawing.Point(162, 20);
            this.dtConfirm.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dtConfirm.Name = "dtConfirm";
            this.dtConfirm.ShowCheckBox = true;
            this.dtConfirm.Size = new System.Drawing.Size(153, 24);
            this.dtConfirm.TabIndex = 3;
            this.dtConfirm.Value = new System.DateTime(2014, 6, 23, 0, 0, 0, 0);
            this.dtConfirm.ValueChanged += new System.EventHandler(this.dtConfirm_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(162, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(9, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Confirmed:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Recorded:";
            // 
            // dtRecord
            // 
            this.dtRecord.CustomFormat = "  MM/dd/yyyy";
            this.dtRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtRecord.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtRecord.Location = new System.Drawing.Point(3, 20);
            this.dtRecord.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dtRecord.Name = "dtRecord";
            this.dtRecord.Size = new System.Drawing.Size(153, 24);
            this.dtRecord.TabIndex = 2;
            this.dtRecord.Value = new System.DateTime(2014, 6, 23, 0, 0, 0, 0);
            this.dtRecord.ValueChanged += new System.EventHandler(this.dtRecord_ValueChanged);
            // 
            // cbxBanks
            // 
            this.cbxBanks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxBanks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxBanks.FormattingEnabled = true;
            this.cbxBanks.Location = new System.Drawing.Point(162, 70);
            this.cbxBanks.Name = "cbxBanks";
            this.cbxBanks.Size = new System.Drawing.Size(153, 26);
            this.cbxBanks.TabIndex = 5;
            // 
            // cbxExpenses
            // 
            this.cbxExpenses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxExpenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxExpenses.FormattingEnabled = true;
            this.cbxExpenses.Location = new System.Drawing.Point(321, 122);
            this.cbxExpenses.Name = "cbxExpenses";
            this.cbxExpenses.Size = new System.Drawing.Size(153, 26);
            this.cbxExpenses.TabIndex = 6;
            // 
            // cbxBuckets
            // 
            this.cbxBuckets.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxBuckets.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxBuckets.FormattingEnabled = true;
            this.cbxBuckets.Location = new System.Drawing.Point(321, 70);
            this.cbxBuckets.Name = "cbxBuckets";
            this.cbxBuckets.Size = new System.Drawing.Size(153, 26);
            this.cbxBuckets.TabIndex = 7;
            // 
            // cbxRevenues
            // 
            this.cbxRevenues.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRevenues.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxRevenues.FormattingEnabled = true;
            this.cbxRevenues.Location = new System.Drawing.Point(162, 122);
            this.cbxRevenues.Name = "cbxRevenues";
            this.cbxRevenues.Size = new System.Drawing.Size(153, 26);
            this.cbxRevenues.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(321, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Brief Description:";
            // 
            // txtBrief
            // 
            this.txtBrief.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBrief.Location = new System.Drawing.Point(321, 20);
            this.txtBrief.Name = "txtBrief";
            this.txtBrief.Size = new System.Drawing.Size(312, 24);
            this.txtBrief.TabIndex = 10;
            this.txtBrief.TextChanged += new System.EventHandler(this.txtBrief_TextChanged);
            // 
            // cbxBudgets
            // 
            this.cbxBudgets.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxBudgets.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxBudgets.FormattingEnabled = true;
            this.cbxBudgets.Location = new System.Drawing.Point(3, 122);
            this.cbxBudgets.Name = "cbxBudgets";
            this.cbxBudgets.Size = new System.Drawing.Size(153, 26);
            this.cbxBudgets.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 50);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 3, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Action:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(162, 50);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 3, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Bank:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(321, 50);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 3, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Bucket:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 102);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 3, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Budget:";
            // 
            // cbxAction
            // 
            this.cbxAction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxAction.FormattingEnabled = true;
            this.cbxAction.Items.AddRange(new object[] {
            "Budget Income",
            "Make Deposit",
            "Make Withdrawal",
            "Write Expense",
            "Write Revenue"});
            this.cbxAction.Location = new System.Drawing.Point(3, 70);
            this.cbxAction.Name = "cbxAction";
            this.cbxAction.Size = new System.Drawing.Size(153, 26);
            this.cbxAction.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(162, 102);
            this.label8.Margin = new System.Windows.Forms.Padding(3, 3, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "Revenue:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(321, 102);
            this.label9.Margin = new System.Windows.Forms.Padding(3, 3, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 17);
            this.label9.TabIndex = 18;
            this.label9.Text = "Expense:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(480, 50);
            this.label10.Margin = new System.Windows.Forms.Padding(3, 3, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 17);
            this.label10.TabIndex = 19;
            this.label10.Text = "Amount:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 154);
            this.label12.Margin = new System.Windows.Forms.Padding(3, 3, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 17);
            this.label12.TabIndex = 21;
            this.label12.Text = "Notes:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(480, 102);
            this.label11.Margin = new System.Windows.Forms.Padding(3, 3, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 17);
            this.label11.TabIndex = 20;
            this.label11.Text = "Company:";
            // 
            // btnTicket
            // 
            this.btnTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTicket.Location = new System.Drawing.Point(480, 174);
            this.btnTicket.Name = "btnTicket";
            this.btnTicket.Size = new System.Drawing.Size(153, 49);
            this.btnTicket.TabIndex = 22;
            this.btnTicket.Text = "Add Ticket";
            this.btnTicket.UseVisualStyleBackColor = true;
            // 
            // txtCompany
            // 
            this.txtCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompany.Location = new System.Drawing.Point(480, 122);
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.Size = new System.Drawing.Size(153, 24);
            this.txtCompany.TabIndex = 23;
            // 
            // numAmount
            // 
            this.numAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numAmount.Location = new System.Drawing.Point(480, 69);
            this.numAmount.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numAmount.Name = "numAmount";
            this.numAmount.Size = new System.Drawing.Size(153, 27);
            this.numAmount.TabIndex = 24;
            this.numAmount.ThousandsSeparator = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(480, 229);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 49);
            this.button2.TabIndex = 26;
            this.button2.Text = "Save Transaction";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // lblTickets
            // 
            this.lblTickets.Controls.Add(this.panel1);
            this.lblTickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTickets.Location = new System.Drawing.Point(3, 284);
            this.lblTickets.Name = "lblTickets";
            this.lblTickets.Size = new System.Drawing.Size(630, 276);
            this.lblTickets.TabIndex = 27;
            this.lblTickets.TabStop = false;
            this.lblTickets.Text = "Tickets";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(3, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(624, 250);
            this.panel1.TabIndex = 0;
            // 
            // TransactionFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblTickets);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.numAmount);
            this.Controls.Add(this.txtCompany);
            this.Controls.Add(this.btnTicket);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbxAction);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbxBudgets);
            this.Controls.Add(this.txtBrief);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbxRevenues);
            this.Controls.Add(this.cbxBuckets);
            this.Controls.Add(this.cbxExpenses);
            this.Controls.Add(this.cbxBanks);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtRecord);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtConfirm);
            this.Controls.Add(this.txtDetails);
            this.Name = "TransactionFrame";
            this.Size = new System.Drawing.Size(636, 563);
            ((System.ComponentModel.ISupportInitialize)(this.numAmount)).EndInit();
            this.lblTickets.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDetails;
        private System.Windows.Forms.DateTimePicker dtConfirm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtRecord;
        private System.Windows.Forms.ComboBox cbxBanks;
        private System.Windows.Forms.ComboBox cbxExpenses;
        private System.Windows.Forms.ComboBox cbxBuckets;
        private System.Windows.Forms.ComboBox cbxRevenues;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBrief;
        private System.Windows.Forms.ComboBox cbxBudgets;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbxAction;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnTicket;
        private System.Windows.Forms.TextBox txtCompany;
        private System.Windows.Forms.NumericUpDown numAmount;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox lblTickets;
        private System.Windows.Forms.Panel panel1;
    }
}
