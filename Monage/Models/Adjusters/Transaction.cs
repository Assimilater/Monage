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
            this.Tickets = new List<Ticket>();
            this.Brief = "";
            this.Details = "";
            this.Incurred = DateTime.Now;
            this.Confirmed = null;
        }
        public Transaction(User user) {
            this.User = user;
            this.User_ID = user.ID;
            this.Brief = "";
            this.Details = "";
            this.Tickets = new List<Ticket>();
            this.Incurred = DateTime.Now;
            this.Confirmed = null;
        }

        public void Validate() {
            // Check that this transaction isn't meaningless
            if (!this.Tickets.Any()) {
                throw new ValidationException("This transaction has no tickets");
            }

            // Check the incurred and confirmed dates
            if (this.Confirmed != null) {
                if (this.Confirmed.Value.Date < this.Incurred.Date) {
                    throw new ValidationException("Transaction marked as confirmed before it was incurred");
                }
            }

            // Check that it has sufficient descriptors
            if (String.IsNullOrEmpty(this.Brief.Trim())) {
                throw new ValidationException("Add a brief description of what this transaction represents");
            }

            if (this.Brief.Length > Settings.NameLen) {
                throw new ValidationException("Brief is too long, make it brief (less than 45 characters)");
            }

            // Check each individual ticket is valid
            foreach (Ticket ticket in this.Tickets) { ticket.Validate(); }

            // Check the transaction is balanced
            if (this.Tickets.Sum(x => x.Amount) != 0) {
                throw new ValidationException("This transaction's tickets are not balanced");
            }
        }

        public Transaction Save() {
            this.Validate();
            if (this.ID == 0) {
                Session.db.Transactions.Add(this);
            }
            Session.db.SaveChanges();
            foreach (Ticket ticket in this.Tickets) {
                if (ticket.ID == 0) {
                    ticket.Transaction_ID = this.ID;
                    Session.db.Tickets.Add(ticket);
                }
            }
            Session.db.SaveChanges();
            return this;
        }
    }
}
