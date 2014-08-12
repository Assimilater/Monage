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
            this.dtIncur = new System.Windows.Forms.DateTimePicker();
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
            this.btnAddTicket = new System.Windows.Forms.Button();
            this.txtCompany = new System.Windows.Forms.TextBox();
            this.numAmount = new System.Windows.Forms.NumericUpDown();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblCreditAmount = new System.Windows.Forms.Label();
            this.lblDebitAmount = new System.Windows.Forms.Label();
            this.lblCheck = new System.Windows.Forms.Label();
            this.pnlCheck = new System.Windows.Forms.Panel();
            this.TicketList = new Monage.GUI.Controls.TicketList();
            this.pnlEdit = new System.Windows.Forms.Panel();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.pnlLeftIndent = new System.Windows.Forms.Panel();
            this.pnlRightIndent = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.numAmount)).BeginInit();
            this.pnlCheck.SuspendLayout();
            this.pnlEdit.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDetails
            // 
            this.txtDetails.Location = new System.Drawing.Point(3, 174);
            this.txtDetails.Multiline = true;
            this.txtDetails.Name = "txtDetails";
            this.txtDetails.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDetails.Size = new System.Drawing.Size(406, 98);
            this.txtDetails.TabIndex = 5;
            this.txtDetails.TextChanged += new System.EventHandler(this.txtDetails_TextChanged);
            // 
            // dtConfirm
            // 
            this.dtConfirm.CustomFormat = "  MM/dd/yyyy";
            this.dtConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtConfirm.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtConfirm.Location = new System.Drawing.Point(209, 20);
            this.dtConfirm.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dtConfirm.Name = "dtConfirm";
            this.dtConfirm.ShowCheckBox = true;
            this.dtConfirm.Size = new System.Drawing.Size(200, 24);
            this.dtConfirm.TabIndex = 1;
            this.dtConfirm.Value = new System.DateTime(2014, 6, 23, 0, 0, 0, 0);
            this.dtConfirm.ValueChanged += new System.EventHandler(this.dtConfirm_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(209, 0);
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
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Incurred:";
            // 
            // dtIncur
            // 
            this.dtIncur.CustomFormat = "  MM/dd/yyyy";
            this.dtIncur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtIncur.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtIncur.Location = new System.Drawing.Point(3, 20);
            this.dtIncur.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dtIncur.Name = "dtIncur";
            this.dtIncur.Size = new System.Drawing.Size(200, 24);
            this.dtIncur.TabIndex = 0;
            this.dtIncur.Value = new System.DateTime(2014, 6, 23, 0, 0, 0, 0);
            this.dtIncur.ValueChanged += new System.EventHandler(this.dtIncur_ValueChanged);
            // 
            // cbxBanks
            // 
            this.cbxBanks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxBanks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxBanks.FormattingEnabled = true;
            this.cbxBanks.Location = new System.Drawing.Point(209, 70);
            this.cbxBanks.Name = "cbxBanks";
            this.cbxBanks.Size = new System.Drawing.Size(200, 26);
            this.cbxBanks.TabIndex = 7;
            // 
            // cbxExpenses
            // 
            this.cbxExpenses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxExpenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxExpenses.FormattingEnabled = true;
            this.cbxExpenses.Location = new System.Drawing.Point(415, 122);
            this.cbxExpenses.Name = "cbxExpenses";
            this.cbxExpenses.Size = new System.Drawing.Size(200, 26);
            this.cbxExpenses.TabIndex = 11;
            // 
            // cbxBuckets
            // 
            this.cbxBuckets.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxBuckets.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxBuckets.FormattingEnabled = true;
            this.cbxBuckets.Location = new System.Drawing.Point(415, 70);
            this.cbxBuckets.Name = "cbxBuckets";
            this.cbxBuckets.Size = new System.Drawing.Size(200, 26);
            this.cbxBuckets.TabIndex = 8;
            // 
            // cbxRevenues
            // 
            this.cbxRevenues.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRevenues.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxRevenues.FormattingEnabled = true;
            this.cbxRevenues.Location = new System.Drawing.Point(209, 122);
            this.cbxRevenues.Name = "cbxRevenues";
            this.cbxRevenues.Size = new System.Drawing.Size(200, 26);
            this.cbxRevenues.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(415, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Brief Description:";
            // 
            // txtBrief
            // 
            this.txtBrief.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtBrief.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtBrief.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBrief.Location = new System.Drawing.Point(415, 20);
            this.txtBrief.MaxLength = 45;
            this.txtBrief.Name = "txtBrief";
            this.txtBrief.Size = new System.Drawing.Size(365, 24);
            this.txtBrief.TabIndex = 2;
            this.txtBrief.TextChanged += new System.EventHandler(this.txtBrief_TextChanged);
            // 
            // cbxBudgets
            // 
            this.cbxBudgets.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxBudgets.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxBudgets.FormattingEnabled = true;
            this.cbxBudgets.Location = new System.Drawing.Point(3, 122);
            this.cbxBudgets.Name = "cbxBudgets";
            this.cbxBudgets.Size = new System.Drawing.Size(200, 26);
            this.cbxBudgets.TabIndex = 9;
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
            this.label5.Location = new System.Drawing.Point(209, 50);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 3, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Bank:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(415, 50);
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
            "Withdraw Expense",
            "Deposit Revenue",
            "Apply Budget",
            "Make Withdrawal",
            "Make Deposit",
            "Write Revenue",
            "Write Expense"});
            this.cbxAction.Location = new System.Drawing.Point(3, 70);
            this.cbxAction.Name = "cbxAction";
            this.cbxAction.Size = new System.Drawing.Size(200, 26);
            this.cbxAction.TabIndex = 6;
            this.cbxAction.SelectedIndexChanged += new System.EventHandler(this.cbxAction_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(209, 102);
            this.label8.Margin = new System.Windows.Forms.Padding(3, 3, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "Revenue:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(415, 102);
            this.label9.Margin = new System.Windows.Forms.Padding(3, 3, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 17);
            this.label9.TabIndex = 18;
            this.label9.Text = "Expense:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(621, 50);
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
            this.label11.Location = new System.Drawing.Point(621, 102);
            this.label11.Margin = new System.Windows.Forms.Padding(3, 3, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 17);
            this.label11.TabIndex = 20;
            this.label11.Text = "Company:";
            // 
            // btnAddTicket
            // 
            this.btnAddTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTicket.Location = new System.Drawing.Point(415, 174);
            this.btnAddTicket.Name = "btnAddTicket";
            this.btnAddTicket.Size = new System.Drawing.Size(365, 46);
            this.btnAddTicket.TabIndex = 12;
            this.btnAddTicket.Text = "Add Ticket(s)";
            this.btnAddTicket.UseVisualStyleBackColor = true;
            this.btnAddTicket.Click += new System.EventHandler(this.btnAddTicket_Click);
            // 
            // txtCompany
            // 
            this.txtCompany.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtCompany.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompany.Location = new System.Drawing.Point(621, 122);
            this.txtCompany.MaxLength = 45;
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.Size = new System.Drawing.Size(159, 24);
            this.txtCompany.TabIndex = 4;
            // 
            // numAmount
            // 
            this.numAmount.DecimalPlaces = 2;
            this.numAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numAmount.Location = new System.Drawing.Point(621, 69);
            this.numAmount.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numAmount.Name = "numAmount";
            this.numAmount.Size = new System.Drawing.Size(159, 27);
            this.numAmount.TabIndex = 3;
            this.numAmount.ThousandsSeparator = true;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(415, 226);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(365, 46);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save Transaction";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblCreditAmount
            // 
            this.lblCreditAmount.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreditAmount.Location = new System.Drawing.Point(609, 2);
            this.lblCreditAmount.Margin = new System.Windows.Forms.Padding(3);
            this.lblCreditAmount.Name = "lblCreditAmount";
            this.lblCreditAmount.Size = new System.Drawing.Size(167, 26);
            this.lblCreditAmount.TabIndex = 29;
            this.lblCreditAmount.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // lblDebitAmount
            // 
            this.lblDebitAmount.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDebitAmount.Location = new System.Drawing.Point(436, 1);
            this.lblDebitAmount.Margin = new System.Windows.Forms.Padding(3);
            this.lblDebitAmount.Name = "lblDebitAmount";
            this.lblDebitAmount.Size = new System.Drawing.Size(167, 26);
            this.lblDebitAmount.TabIndex = 28;
            this.lblDebitAmount.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // lblCheck
            // 
            this.lblCheck.AutoSize = true;
            this.lblCheck.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheck.Location = new System.Drawing.Point(330, 4);
            this.lblCheck.Margin = new System.Windows.Forms.Padding(3, 3, 2, 0);
            this.lblCheck.Name = "lblCheck";
            this.lblCheck.Size = new System.Drawing.Size(101, 23);
            this.lblCheck.TabIndex = 30;
            this.lblCheck.Text = "Check Sum:";
            // 
            // pnlCheck
            // 
            this.pnlCheck.BackColor = System.Drawing.SystemColors.Control;
            this.pnlCheck.Controls.Add(this.lblDebitAmount);
            this.pnlCheck.Controls.Add(this.lblCheck);
            this.pnlCheck.Controls.Add(this.lblCreditAmount);
            this.pnlCheck.Location = new System.Drawing.Point(0, 532);
            this.pnlCheck.Margin = new System.Windows.Forms.Padding(0);
            this.pnlCheck.Name = "pnlCheck";
            this.pnlCheck.Size = new System.Drawing.Size(866, 33);
            this.pnlCheck.TabIndex = 31;
            // 
            // TicketList
            // 
            this.TicketList.Location = new System.Drawing.Point(3, 278);
            this.TicketList.Name = "TicketList";
            this.TicketList.Size = new System.Drawing.Size(860, 251);
            this.TicketList.TabIndex = 32;
            // 
            // pnlEdit
            // 
            this.pnlEdit.Controls.Add(this.btnSave);
            this.pnlEdit.Controls.Add(this.txtDetails);
            this.pnlEdit.Controls.Add(this.numAmount);
            this.pnlEdit.Controls.Add(this.dtConfirm);
            this.pnlEdit.Controls.Add(this.txtCompany);
            this.pnlEdit.Controls.Add(this.label2);
            this.pnlEdit.Controls.Add(this.btnAddTicket);
            this.pnlEdit.Controls.Add(this.dtIncur);
            this.pnlEdit.Controls.Add(this.label12);
            this.pnlEdit.Controls.Add(this.label1);
            this.pnlEdit.Controls.Add(this.label11);
            this.pnlEdit.Controls.Add(this.cbxBanks);
            this.pnlEdit.Controls.Add(this.label10);
            this.pnlEdit.Controls.Add(this.cbxExpenses);
            this.pnlEdit.Controls.Add(this.label9);
            this.pnlEdit.Controls.Add(this.cbxBuckets);
            this.pnlEdit.Controls.Add(this.label8);
            this.pnlEdit.Controls.Add(this.cbxRevenues);
            this.pnlEdit.Controls.Add(this.cbxAction);
            this.pnlEdit.Controls.Add(this.label3);
            this.pnlEdit.Controls.Add(this.label7);
            this.pnlEdit.Controls.Add(this.txtBrief);
            this.pnlEdit.Controls.Add(this.label6);
            this.pnlEdit.Controls.Add(this.cbxBudgets);
            this.pnlEdit.Controls.Add(this.label5);
            this.pnlEdit.Controls.Add(this.label4);
            this.pnlEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEdit.Location = new System.Drawing.Point(40, 0);
            this.pnlEdit.Name = "pnlEdit";
            this.pnlEdit.Size = new System.Drawing.Size(786, 272);
            this.pnlEdit.TabIndex = 33;
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.pnlEdit);
            this.pnlTop.Controls.Add(this.pnlLeftIndent);
            this.pnlTop.Controls.Add(this.pnlRightIndent);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(866, 272);
            this.pnlTop.TabIndex = 36;
            // 
            // pnlLeftIndent
            // 
            this.pnlLeftIndent.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeftIndent.Location = new System.Drawing.Point(0, 0);
            this.pnlLeftIndent.Name = "pnlLeftIndent";
            this.pnlLeftIndent.Size = new System.Drawing.Size(40, 272);
            this.pnlLeftIndent.TabIndex = 36;
            // 
            // pnlRightIndent
            // 
            this.pnlRightIndent.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlRightIndent.Location = new System.Drawing.Point(826, 0);
            this.pnlRightIndent.Name = "pnlRightIndent";
            this.pnlRightIndent.Size = new System.Drawing.Size(40, 272);
            this.pnlRightIndent.TabIndex = 37;
            // 
            // TransactionFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.TicketList);
            this.Controls.Add(this.pnlCheck);
            this.Name = "TransactionFrame";
            this.Size = new System.Drawing.Size(866, 565);
            ((System.ComponentModel.ISupportInitialize)(this.numAmount)).EndInit();
            this.pnlCheck.ResumeLayout(false);
            this.pnlCheck.PerformLayout();
            this.pnlEdit.ResumeLayout(false);
            this.pnlEdit.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtDetails;
        private System.Windows.Forms.DateTimePicker dtConfirm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtIncur;
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
        private System.Windows.Forms.Button btnAddTicket;
        private System.Windows.Forms.TextBox txtCompany;
        private System.Windows.Forms.NumericUpDown numAmount;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblCreditAmount;
        private System.Windows.Forms.Label lblDebitAmount;
        private System.Windows.Forms.Label lblCheck;
        private System.Windows.Forms.Panel pnlCheck;
        private Controls.TicketList TicketList;
        private System.Windows.Forms.Panel pnlEdit;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlLeftIndent;
        private System.Windows.Forms.Panel pnlRightIndent;
    }
}
