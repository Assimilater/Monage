using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monage.Models {
    public class Amount {
        public double Physical { get; set; }
        public double Actual { get; set; }

        public Amount() { Physical = 0; Actual = 0; }
        public Amount(double a) { Physical = a; Actual = a; }
        public Amount(double p, double a) { Physical = p; Actual = a; }

        public Amount(Bank b, Amount o) { Aggregate(b.Balances); Add(o); }
        public Amount(Bucket b) { Aggregate(b.Balances); }

        private void Aggregate(List<Balance> balances) {
            Physical = 0; Actual = 0;
            foreach (Balance b in balances) {
                this.Add(b.Amount);
            }
        }
        private void Add(Amount a) {
            this.Physical += a.Physical;
            this.Actual += a.Actual;
        }

        public override string ToString() {
            return String.Format(
                "{0:C} [{1:C}]",
                Physical,
                Actual
            );
        }
    }
}
