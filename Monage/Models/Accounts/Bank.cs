using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

        public virtual User User { get; set; }

        #endregion

        public static List<Bank> Enumerate(User u) {
            return Program.db.Banks.Where(x => x.User.ID == u.ID).OrderBy(x => x.Name).ToList();
        }

        public Bank() { }
        public Bank(User user) { User = user; }
        
        public Amount GetBalance(Bucket b = null) { return new Amount(this, b); }

        public Bank Rename(Pair val) {
            if (val != null) {
                bool changes = false;
                
                if (Description != val.Description) {
                    Description = val.Description;
                    changes = true;
                }

                if (Name != val.Name && val.Name != "") {
                    if (Program.db.Banks.Where(x => x.User.ID == User.ID && x.Name == val.Name).Any()) {
                        throw new ValidationException("A bank named \"" + val.Name + "\" already exists");
                    } else {
                        Name = val.Name;
                        changes = true;
                    }
                }
                
                if (changes) {
                    try {
                        if (ID == 0) { Program.db.Banks.Add(this); }
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
