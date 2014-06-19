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
        private double? _Expected = null, _Confirmed = null;
        public double Confirmed {
            get {
                if (_Confirmed != null) { return _Confirmed.Value; }
                double Amount = 0;

                return Amount;
            }
        }
        public double Expected {
            get {
                if (_Expected != null) { return _Expected.Value; }
                double Amount = 0;

                return Amount;
            }
        }

        public Amount(double confirmed, double expected) {
            this.Bank = null;
            this.Bucket = null;
            this._Expected = expected;
            this._Confirmed = confirmed;
        }

        public Amount(Bank bank, Bucket bucket) {
            if (bank == null && bucket == null) {
                throw new Exception("A null bank/bucket pair is invalid");
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
