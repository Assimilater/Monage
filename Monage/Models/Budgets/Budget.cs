using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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

        [ForeignKey("User_ID")]
        public virtual User User { get; set; }
        public int User_ID { get; set; }

        [ForeignKey("Final_ID")]
        public virtual Bucket Final { get; set; }
        public int Final_ID { get; set; }

        public virtual List<Tier> Tiers { get; set; }

        #endregion

        public static IEnumerable<Budget> Enumerate() {
            //return Session.db.Budgets.Where(x => x.User_ID == Session.User.ID).OrderBy(x => x.Name);
            return new List<Budget>();
        }

        public Budget() {
            this.Tiers = new List<Tier>();
        }
        public Budget(User user) {
            this.User = user;
            this.Tiers = new List<Tier>();
        }

        private void Validate() {
            if (this.ID == 0 &&
                Session.db.Buckets.Count(x => x.User_ID == this.User_ID) == 0 &&
                Session.db.Banks.Count(x => x.User_ID == this.User_ID) == 0) {
                throw new ValidationException("You can't create a budget without at least one bank and one bucket");
            }
        }

        public void Save() {
            this.Validate();
            try {
                //if (this.ID == 0) { Session.db.Budgets.Add(this); }
                Session.db.SaveChanges();
            } catch {
                throw new ValidationException("An unkown exception has occured");
            }
        }

        public Budget Rename(Pair val) {
            if (val != null) {
                bool changes = false;

                if (this.Description != val.Description) {
                    this.Description = val.Description;
                    changes = true;
                }

                if (this.Name != val.Name && val.Name != "") {
                    //if (Session.db.Budgets.Where(x => x.User_ID == this.User_ID && x.Name == val.Name).Any()) {
                    //    throw new ValidationException("A budget named \"" + val.Name + "\" already exists");
                    //} else {
                    //    this.Name = val.Name;
                    //    changes = true;
                    //}
                }

                if (changes && this.ID == 0) {
                    this.Validate();
                } else if (changes) {
                    this.Save();
                }
            }
            return this;
        }
    }
}
