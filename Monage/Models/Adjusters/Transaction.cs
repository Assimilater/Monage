using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monage.Models {
    public class Transaction {
        #region Schema

        [Key]
        public int ID { get; set; }

        [Required]
        [MaxLength(Settings.NameLen)]
        public string Brief { get; set; }
        public string Details { get; set; }

        [Required]
        public DateTime Incurred { get; set; }
        public DateTime? Confirmed { get; set; }

        public virtual List<Debit> Debits { get; set; }
        public virtual List<Credit> Credits { get; set; }

        #endregion

        public Transaction() {
            Debits = new List<Debit>();
            Credits = new List<Credit>();
            Incurred = DateTime.Now;
            Confirmed = null;
        }

        public bool Valid() {
            return false;
        }

        public Transaction Save() {
            if (Valid()) {
                if (ID == 0) {
                    Program.db.Transactions.Add(this);
                    foreach (Debit t in Debits) {
                        Program.db.Debits.Add(t);
                    }
                    foreach (Credit t in Credits) {
                        Program.db.Credits.Add(t);
                    }
                    Program.db.SaveChanges();
                }
            }
            return this;
        }
    }
}
