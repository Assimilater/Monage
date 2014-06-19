using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monage.Models {
    public class Amount {
        public Bank Bank { get; private set; }
        public Bucket Bucket { get; private set; }

        public double Confirmed {
            get {
                double Amount = 0;

                return Amount;
            }
        }
        public double Expected {
            get {
                double Amount = 0;

                return Amount;
            }
        }

        public Amount(Bank bank, Bucket bucket) {
            if (bank == null && bucket == null) {

            }
            this.Bank = bank;
            this.Bucket = bucket;
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
