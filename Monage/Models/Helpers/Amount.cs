using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monage.Models {
    public class Amount {
        public double Confirmed { get; private set; }
        public double Expected { get; private set; }

        public Amount(double confirmed, double expected) {
            this.Expected = expected;
            this.Confirmed = confirmed;
        }

        public Amount(Bank bank, Bucket bucket) {
            if (bank == null && bucket == null) {
                throw new Exception("A null bank/bucket pair is invalid");
            }

            IEnumerable<Ticket> Aggregate = Session.db.Tickets;
            if (bank != null) {
                Aggregate = Aggregate.Where(x => x.Bank_ID == bank.ID);
            }
            if (bucket != null) {
                Aggregate = Aggregate.Where(x => x.Bucket_ID == bucket.ID);
            }

            this.Confirmed = Aggregate.Where(x => x.Transaction.Confirmed != null).Sum(x => x.Amount);
            this.Expected = Aggregate.Sum(x => x.Amount);
        }

        public override string ToString() {
            return String.Format(
                "{0:C} [ {1:C} ]",
                Confirmed,
                Expected
            );
        }
    }
}
