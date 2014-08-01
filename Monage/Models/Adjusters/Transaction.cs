using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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

        public virtual List<Ticket> Tickets { get; set; }

        [ForeignKey("User_ID")]
        public virtual User User { get; set; }
        public int User_ID { get; set; }

        #endregion

        public Transaction() {
            Tickets = new List<Ticket>();
            Incurred = DateTime.Now;
            Confirmed = null;
        }

        public void Validate() {
            // Check that this transaction isn't meaningless
            if (this.Tickets.Count() == 0) {
                throw new ValidationException("This transaction has no tickets");
            }

            // Check the incurred and confirmed dates
            if (this.Confirmed != null) {
                if (this.Confirmed < this.Incurred) {
                    throw new ValidationException("Transaction marked as confirmed before it was incurred");
                }
            }

            // Check that it has sufficient descriptors
            if (this.Brief == "") {
                throw new ValidationException("Add a brief description of what this transaction represents");
            }

            // Check each individual ticket is valid
            foreach (Ticket ticket in this.Tickets) { ticket.Validate(); }

            // Check the transaction is balanced
            if (this.Tickets.Sum(x => x.Amount) != 0) {
                throw new ValidationException("This transaction's tickets are not balanced");
            }
        }

        public Transaction Save() {
            Validate();
            if (ID == 0) {
                Program.db.Transactions.Add(this);
                foreach (Ticket t in this.Tickets) {
                    Program.db.Tickets.Add(t);
                }
                Program.db.SaveChanges();
            }
            return this;
        }
    }
}
