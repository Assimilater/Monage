using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monage.Models {
    public class User {
        #region Schema

        [Key]
        public int ID { get; set; }

        [Required]
        [MaxLength(Settings.NameLen)]
        public string Username { get; set; }

        public virtual List<Bank> Banks { get; set; }
        public virtual List<Bucket> Buckets { get; set; }
        public virtual List<Budget> Budgets { get; set; }

        #endregion

        public User() {
            this.Banks = new List<Bank>();
            this.Buckets = new List<Bucket>();
            this.Budgets = new List<Budget>();
        }

        public User Rename(String name) {
            if (this.Username != name && !String.IsNullOrEmpty(name)) {
                if (Session.db.Users.Any(x => x.Username == name)) {
                    throw new ValidationException("Username \"" + name + "\" is already in use");
                } else {
                    try {
                        this.Username = name;
                        if (this.ID == 0) { Session.db.Users.Add(this); }
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
