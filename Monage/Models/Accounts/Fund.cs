using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monage.Models {
    public enum BalanceType { Debit, Credit }
    public class Fund {
        #region Schema

        [Key]
        public int ID { get; set; }

        [Required]
        [MaxLength(Settings.NameLen)]
        public string Name { get; set; }
        public string Description { get; set; }
        public BalanceType BalanceType { get; set; }

        [ForeignKey("User_ID")]
        public virtual User User { get; set; }
        public int User_ID { get; set; }

        #endregion

        public static IEnumerable<Fund> Enumerate(BalanceType balancetype) {
            return Session.db.Funds.Where(x => x.User_ID == Session.User.ID && x.BalanceType == balancetype).OrderBy(x => x.Name);
        }

        public Fund() { this.BalanceType = BalanceType.Debit; }
        public Fund(User user, BalanceType balancetype) {
            this.User = user;
            this.User_ID = user.ID;
            this.BalanceType = balancetype;
        }

        public Fund Rename(Pair val) {
            if (val != null) {
                bool changes = false;

                if (this.Description != val.Description) {
                    this.Description = val.Description;
                    changes = true;
                }

                if (this.Name != val.Name && val.Name != "") {
                    if (Session.db.Funds.Any(x => x.User_ID == this.User_ID && x.Name == val.Name)) {
                        throw new ValidationException("A fund named \"" + val.Name + "\" already exists");
                    } else {
                        this.Name = val.Name;
                        changes = true;
                    }
                }

                if (changes) {
                    try {
                        if (this.ID == 0) { Session.db.Funds.Add(this); }
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
