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
        [MaxLength(Program.NameLen)]
        public string Brief { get; set; }
        public string Details { get; set; }

        [Required]
        public DateTime Created { get; set; }
        public DateTime? Confirmed { get; set; }

        public virtual List<Ticket> Tickets { get; set; }

        #endregion

        public Transaction() {
            Tickets = new List<Ticket>();
            Created = DateTime.Now;
            Confirmed = null;
        }

        public bool Valid() {
            return false;
        }

        public Transaction Save() {
            if (Valid()) {
                if (ID == 0) {
                    Program.db.Transactions.Add(this);
                    foreach (Ticket t in Tickets) {
                        Program.db.Tickets.Add(t);
                    }
                    Program.db.SaveChanges();
                }
            }
            return this;
        }
    }
}
