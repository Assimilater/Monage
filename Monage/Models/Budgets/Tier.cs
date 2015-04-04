using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monage.Models {
    public enum TierStrategy {
        Ratio = 0,
        Fixed = 1
    }
    public class Tier {
        [Key]
        public int ID { get; set; }
        public int Order { get; set; }
        public TierStrategy Type { get; set; }

        [ForeignKey("Budget_ID")]
        public virtual Budget Budget { get; set; }
        public int Budget_ID { get; set; }

        public virtual List<Step> Steps { get; set; }

        public Tier() {
            this.Steps = new List<Step>();
        }

        public void AddStep() {
            Step step = new Step();
            step.Tier = this;
            step.Tier_ID = this.ID;
            step.Order = this.Steps.Count() + 1;
            step.Bucket = Bucket.Enumerate().First();
            step.Bucket_ID = step.Bucket.ID;
            this.Steps.Add(step);
        }

        public void Validate() {
            if (!this.Steps.Any()) {
                throw new ValidationException("Tier does not contain any steps");
            }
            int count = 1;
            foreach (Step step in this.Steps.OrderBy(x => x.Order)) {
                step.Validate();
                if (step.Order < count) {
                    throw new ValidationException(
                        "Tier " + this.Order + " contains two steps with index " + step.Order);
                } else if (step.Order > count) {
                    throw new ValidationException(
                        "Tier " + this.Order + " contains gap at index " + count);
                }
                ++count;
            }
        }
    }
}
