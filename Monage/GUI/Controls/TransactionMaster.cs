﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Monage.Models;
using Monage.GUI.Frames;

namespace Monage.GUI.Controls {
    public partial class TransactionMaster : UserControl {
        private bool _Expanded;
        public bool Expanded {
            get { return this._Expanded; }
            set {
                this._Expanded = value;
                this.Height = value ? 475 : 34;
                this.btnExpand.Image = value
                    ? Properties.Resources.IconMinus
                    : Properties.Resources.IconPlus;

                this.ParentFrame.AdjustList();
            }
        }

        private double Total;
        private int TransactionID;
        private Transaction Transaction;
        private HistoryFrame ParentFrame;
        private TicketList TicketList;

        private void init() {
            this._Expanded = false;
            this.Height = 34;
            this.btnExpand.Image = Properties.Resources.IconPlus;
        }
        public TransactionMaster() { InitializeComponent(); this.init(); }
        public TransactionMaster(Transaction transaction, HistoryFrame parentframe) {
            InitializeComponent();
            this.init();

            this.ParentFrame = parentframe;
            this.Transaction = transaction;
            this.TransactionID = transaction.ID;
            lblDetails.Text = transaction.Details;
            lblBrief.Text = transaction.Brief;
            lblIncurred.Text = transaction.Incurred.ToString("MM/dd/yyyy");
            lblConfirmed.Text = transaction.Confirmed == null
                ? "Never" : transaction.Confirmed.Value.ToString("MM/dd/yyyy");

            this.TicketList = new TicketList(transaction);
            this.TicketList.Location = new Point(6, 189);
            pnlExpanded.Controls.Add(this.TicketList);

            if (Settings.FilterBanks == 0 && Settings.FilterBuckets == 0) {
                lblAfter.Text = (this.Total = transaction.Tickets
                    .Where(x => x.Amount > 0)
                    .Sum(x => x.Amount))
                    .ToString("C");
            } else {
                IEnumerable<Ticket> tickets = Session.db.Tickets;

                if (Settings.FilterConfirmed) {
                    if (this.Transaction.Confirmed != null) {
                        tickets = tickets
                            .Where(x => x.Transaction.Confirmed <= this.Transaction.Confirmed);
                    } else {
                        tickets = tickets
                            .Where(x => x.Transaction.Confirmed != null
                                || x.Transaction.Incurred <= this.Transaction.Incurred);
                    }
                } else {
                    tickets = tickets
                        .Where(x => x.Transaction.Incurred <= this.Transaction.Incurred);
                }

                if (Settings.FilterBanks != 0) {
                    tickets = tickets.Where(x => x.Bank_ID == Settings.FilterBanks);
                }

                if (Settings.FilterBuckets != 0) {
                    tickets = tickets.Where(x => x.Bucket_ID == Settings.FilterBuckets);
                }

                double
                    after = tickets.Sum(x => x.Amount),
                    before = tickets
                        .Where(x => x.Transaction_ID != this.TransactionID)
                        .Sum(x => x.Amount);

                lblBefore.Text = before.ToString("C");
                lblAfter.Text = after.ToString("C");
            }
        }

        private void btnExpand_Click(object sender, EventArgs e) { this.Expanded = !this.Expanded; }
        private void btnEdit_Click(object sender, EventArgs e) {
            Program.Host.SetFrame(new TransactionFrame(this.TransactionID));
        }
    }
}
