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

namespace Monage.GUI.Controls {
    public partial class StepMaster : UserControl {
        private bool watch;
        private StepList ParentFrame { get; set; }
        private Step Step { get; set; }
        public StepMaster(StepList parent, Step step) {
            this.watch = false;
            InitializeComponent();
            this.ParentFrame = parent;
            this.Step = step;
            if (this.Step.Tier.Type == TierStrategy.Ratio) {
                numAmount.Value = step.Value * 100;
            } else {
                numAmount.Value = step.Value;
            }

            // Get the list of buckets
            BindingList<KeyValuePair<int, string>>
                Buckets = new BindingList<KeyValuePair<int, string>>();

            foreach (Bucket bucket in Bucket.Enumerate()) {
                Buckets.Add(new KeyValuePair<int, string>(bucket.ID, bucket.Name));
            }

            cbxBuckets.DataSource = Buckets;
            cbxBuckets.ValueMember = "Key";
            cbxBuckets.DisplayMember = "Value";

            cbxBuckets.SelectedValue = this.Step.Bucket_ID;
            this.watch = true;
        }

        private void cbxBuckets_SelectedIndexChanged(object sender, EventArgs e) {
            if (this.watch) {
                this.Step.Bucket_ID = (int)cbxBuckets.SelectedValue;
                this.Step.Bucket = Session.db.Buckets.First(x => x.ID == this.Step.Bucket_ID);
            }
        }

        private void numAmount_ValueChanged(object sender, EventArgs e) {
            if (this.watch) {
                if (this.Step.Tier.Type == TierStrategy.Ratio) {
                    this.Step.Value = Math.Round(numAmount.Value / 100, 4);
                } else {
                    this.Step.Value = numAmount.Value;
                }
                this.ParentFrame.updateChecksum();
            }
        }

        private void btnUp_Click(object sender, EventArgs e) {
            if (this.Step.Order > 1) {
                Step above = this.Step
                    .Tier.Steps.First(x => x.Order == this.Step.Order - 1);
                above.Order = this.Step.Order;
                this.Step.Order -= 1;
            }
            this.ParentFrame.getList();
        }

        private void btnDown_Click(object sender, EventArgs e) {
            if (this.Step.Order < this.Step.Tier.Steps.Count()) {
                Step below = this.Step
                    .Tier.Steps.First(x => x.Order == this.Step.Order + 1);
                below.Order = this.Step.Order;
                this.Step.Order += 1;
            }
            this.ParentFrame.getList();
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            foreach (Step step in this.Step
                .Tier.Steps
                    .Where(x => x.Order > this.Step.Order)) {
                step.Order -= 1;
            }

            this.Step.Tier.Steps.Remove(this.Step);

            if (this.Step.ID != 0) {
                Session.db.Steps.Remove(this.Step);
            }

            this.ParentFrame.getList();
        }
    }
}
