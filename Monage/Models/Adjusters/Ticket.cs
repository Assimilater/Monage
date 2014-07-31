using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monage.Models {
    public class Ticket {
        #region Schema

        [Key]
        public int ID { get; set; }

        [Required]
        public double Amount { get; set; }

        public string Company { get; set; }
        public virtual Fund Fund { get; set; }

        public virtual Bank Bank { get; set; }
        public virtual Bucket Bucket { get; set; }

        public virtual User User { get; set; }
        public virtual Transaction Transaction { get; set; }

        #endregion

        public Ticket() {
            Amount = 0;
        }
        public Ticket(User user, Transaction transaction) {
            Amount = 0;
            this.User = user;
            this.Transaction = transaction;
        }

        public void Validate() {
            if (this.Amount == 0) {
                throw new ValidationException("A ticket has no amount applied towards it");
            }
            if (this.Fund == null && this.Bank == null && this.Bucket == null) {
                throw new ValidationException("A ticket is not tied to any expense, revenue, bank, or bucket");
            }
            if (this.Fund != null && (this.Bank != null || this.Bucket != null)) {
                throw new ValidationException("A ticket cannot be tied to both an expense/revenue and a bank/bucket");
            }
            if ((this.Bank != null && this.Bucket == null) || (this.Bank == null && this.Bucket != null)) {
                throw new ValidationException("A ticket does not have a valid bank/bucket combination");
            }
            if (this.Fund != null && this.Company == "") {
                throw new ValidationException("A ticket does not have a company to atribute the espense or revenue to");
            }
        }
    }
}
