using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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

        [ForeignKey("Fund_ID")]
        public virtual Fund Fund { get; set; }
        public int? Fund_ID { get; set; }

        [ForeignKey("Bank_ID")]
        public virtual Bank Bank { get; set; }
        public int? Bank_ID { get; set; }

        [ForeignKey("Bucket_ID")]
        public virtual Bucket Bucket { get; set; }
        public int? Bucket_ID { get; set; }

        [ForeignKey("User_ID")]
        public virtual User User { get; set; }
        public int User_ID { get; set; }

        [ForeignKey("Transaction_ID")]
        public virtual Transaction Transaction { get; set; }
        public int Transaction_ID { get; set; }

        #endregion

        public Ticket() {
            this.Amount = 0;
        }
        public Ticket(User user, Transaction transaction) {
            this.Amount = 0;
            this.User = user;
            this.User_ID = user.ID;
            this.Transaction = transaction;
            this.Transaction_ID = transaction.ID;
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
