using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monage.Models {
    public class Budget {
        #region Schema

        [Key]
        public int ID { get; set; }

        [Required]
        [MaxLength(Settings.NameLen)]
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual User User { get; set; }
        public virtual Bucket Final { get; set; }
        public virtual List<Tier> Tiers { get; set; }

        #endregion

        public static List<Budget> Enumerate(User u) {
            //return Program.db.Budgets.Where(x => x.User.ID == u.ID).OrderBy(x => x.Name).ToList();
            return new List<Budget>();
        }

        public Budget() {
            Tiers = new List<Tier>();
        }
        public Budget(User user) { 
            User = user;
            Tiers = new List<Tier>();
        }

        private void Validate() {
            if (this.ID == 0 &&
                Program.db.Buckets.Count(x => x.User.ID == this.User.ID) == 0 &&
                Program.db.Banks.Count(x => x.User.ID == this.User.ID) == 0) {
                throw new ValidationException("You can't create a budget without at least one bank and one bucket");
            }
        }

        public void Save() {
            Validate();
            try {
                //if (ID == 0) { Program.db.Budgets.Add(this); }
                Program.db.SaveChanges();
            } catch {
                throw new ValidationException("An unkown exception has occured");
            }
        }

        public Budget Rename(Pair val) {
            if (val != null) {
                bool changes = false;

                if (Description != val.Description) {
                    Description = val.Description;
                    changes = true;
                }

                if (Name != val.Name && val.Name != "") {
                    //if (Program.db.Budgets.Where(x => x.User.ID == User.ID && x.Name == val.Name).Any()) {
                    //    throw new ValidationException("A budget named \"" + val.Name + "\" already exists");
                    //} else {
                    //    Name = val.Name;
                    //    changes = true;
                    //}
                }

                if (changes && ID == 0) {
                    Validate();
                } else if (changes) {
                    Save();
                }
            }
            return this;
        }
    }
}
