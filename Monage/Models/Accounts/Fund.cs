using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

        public virtual User User { get; set; }

        #endregion

        public static List<Fund> Enumerate(User u, BalanceType t) {
            return Program.db.Funds.Where(x => x.User.ID == u.ID && x.BalanceType == t).OrderBy(x => x.Name).ToList();
        }

        public Fund() { this.BalanceType = BalanceType.Debit; }
        public Fund(User user, BalanceType balancetype) {
            this.User = user;
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
                    if (Program.db.Funds.Where(x => x.User.ID == this.User.ID && x.Name == val.Name).Any()) {
                        throw new ValidationException("A fund named \"" + val.Name + "\" already exists");
                    } else {
                        this.Name = val.Name;
                        changes = true;
                    }
                }

                if (changes) {
                    try {
                        if (this.ID == 0) { Program.db.Funds.Add(this); }
                        Program.db.SaveChanges();
                    } catch {
                        throw new ValidationException("An unkown exception has occured");
                    }
                }
            }
            return this;
        }
    }
}
