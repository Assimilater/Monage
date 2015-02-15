using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monage.Models {
    public class Bank {
        #region Schema

        [Key]
        public int ID { get; set; }

        [Required]
        [MaxLength(Settings.NameLen)]
        public string Name { get; set; }
        public string Description { get; set; }

        [ForeignKey("User_ID")]
        public virtual User User { get; set; }
        public int User_ID { get; set; }

        #endregion

        public static IEnumerable<Bank> Enumerate() {
            return Session.db.Banks.Where(x => x.User_ID == Session.User.ID).OrderBy(x => x.Name);
        }

        public Bank() { }
        public Bank(User user) {
            this.User = user;
            this.User_ID = user.ID;
        }

        public Amount GetBalance(Bucket bucket = null) { return new Amount(this, bucket); }

        public Bank Rename(Pair val) {
            if (val != null) {
                bool changes = false;

                if (this.Description != val.Description) {
                    this.Description = val.Description;
                    changes = true;
                }

                if (this.Name != val.Name && val.Name != "") {
                    if (Session.db.Banks.Any(x => x.User_ID == this.User_ID && x.Name == val.Name)) {
                        throw new ValidationException("A bank named \"" + val.Name + "\" already exists");
                    } else {
                        this.Name = val.Name;
                        changes = true;
                    }
                }
                
                if (changes) {
                    try {
                        if (this.ID == 0) { Session.db.Banks.Add(this); }
                        Session.db.SaveChanges();
                    } catch {
                        throw new ValidationException("An unkown exception has occured");
                    }
                }
            }
            return this;
        }
    }
}
