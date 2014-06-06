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
        [MaxLength(Program.NameLen)]
        public string Username { get; set; }

        public virtual List<Bank> Banks { get; set; }
        public virtual List<Bucket> Buckets { get; set; }
        public virtual List<Budget> Budgets { get; set; }

        #endregion

        public User() {
            Banks = new List<Bank>();
            Buckets = new List<Bucket>();
            Budgets = new List<Budget>();
        }

        public User Rename(String name) {
            if (Username != name && name != null && name != "") {
                if (Program.db.Users.Where(x => x.Username == name).Any()) {
                    throw new ValidationException("Username \"" + name + "\" is already in use");
                } else {
                    try {
                        Username = name;
                        if (ID == 0) { Program.db.Users.Add(this); }
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
