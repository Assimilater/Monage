using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monage.Models {
    public class Balance {
        #region Schema

        [Key]
        public int ID { get; set; }
        public Amount Amount { get; set; }
        public virtual Bank Bank { get; set; }
        public virtual Bucket Bucket { get; set; }
    }

    public class Amount {
        [Required]
        public double Confirmed { get; set; }
        [Required]
        public double Expected { get; set; }

        #endregion

        public Amount() { Confirmed = 0; Expected = 0; }
        public Amount(double a) { Confirmed = a; Expected = a; }
        public Amount(double p, double a) { Confirmed = p; Expected = a; }

        public Amount(Bank b, Amount o) { Aggregate(b.Balances); Add(o); }
        public Amount(Bucket b) { Aggregate(b.Balances); }

        private void Aggregate(List<Balance> balances) {
            Confirmed = 0; Expected = 0;
            foreach (Balance b in balances) {
                this.Add(b.Amount);
            }
        }
        private void Add(Amount a) {
            this.Confirmed += a.Confirmed;
            this.Expected += a.Expected;
        }

        public override string ToString() {
            return String.Format(
                "{0:C} [{1:C}]",
                Confirmed,
                Expected
            );
        }
    }
}
