using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Monage.Models;
using Monage.GUI.Lists;

namespace Monage.GUI.Controls {
    public partial class StepList : UserControl {
        private BudgetListPane ParentFrame { get; set; }
        private Tier Tier { get; set; }
        private bool watch;
        public StepList() { InitializeComponent(); }
        public StepList(BudgetListPane parent, Tier tier) {
            this.watch = false;
            InitializeComponent();
            this.ParentFrame = parent;
            this.Tier = tier;

            cbxType.DataSource = Enum.GetValues(typeof(TierStrategy));
            cbxType.SelectedItem = this.Tier.Type;

            this.getList();
            this.watch = true;
        }

        public void getList() {
            pnlSteps.Controls.Clear();
            foreach (Step step in this.Tier.Steps) {
                StepMaster sm = new StepMaster(this, step);
                sm.Location = new Point(3, 3 + (33 * (step.Order - 1)));
                pnlSteps.Controls.Add(sm);
            }
            this.Height = 94 + (36 * this.Tier.Steps.Count());
            this.ParentFrame.fixHeight();
            this.updateChecksum();
        }

        public void updateChecksum() {
            decimal total = this.Tier.Steps.Sum(x => x.Value);
            switch (this.Tier.Type) {
                case TierStrategy.Ratio:
                    lblDebitAmount.Text = total.ToString("#0.##%");
                    pnlCheck.BackColor = total <= 0 || total > 100
                        ? Color.MistyRose
                        : Color.White;
                    break;
                case TierStrategy.Fixed:
                    lblDebitAmount.Text = total.ToString("C");
                    pnlCheck.BackColor = total <= 0
                        ? Color.MistyRose
                        : Color.White;
                    break;
                default:
                    lblDebitAmount.Text = "#ERROR#";
                    pnlCheck.BackColor = Color.MistyRose;
                    break;
            }
        }

        private void cbxType_SelectedIndexChanged(object sender, EventArgs e) {
            if (!this.watch) { return; }
            TierStrategy
                before = this.Tier.Type,
                after = (TierStrategy)cbxType.SelectedItem;

            this.Tier.Type = after;
            this.updateChecksum();
            this.getList();
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            this.Tier.AddStep();
            this.getList();
        }

        private void btnUp_Click(object sender, EventArgs e) {
            if (this.Tier.Order > 1) {
                Tier above = this.Tier
                    .Budget.Tiers.First(x => x.Order == this.Tier.Order - 1);
                above.Order = this.Tier.Order;
                this.Tier.Order -= 1;
            }
            this.ParentFrame.getList();
        }

        private void btnDown_Click(object sender, EventArgs e) {
            if (this.Tier.Order < this.Tier.Budget.Tiers.Count()) {
                Tier below = this.Tier
                    .Budget.Tiers.First(x => x.Order == this.Tier.Order + 1);
                below.Order = this.Tier.Order;
                this.Tier.Order += 1;
            }
            this.ParentFrame.getList();
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            foreach (Tier tier in this.Tier
                .Budget.Tiers
                    .Where(x => x.Order > this.Tier.Order)) {
                tier.Order -= 1;
            }
            if (this.Tier.ID != 0) {
                Session.db.Tiers.Remove(this.Tier);
            }
            this.Tier.Budget.Tiers.Remove(this.Tier);
            this.ParentFrame.getList();
        }
    }
}
