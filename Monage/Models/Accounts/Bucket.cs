using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monage.Models {
    public class Bucket {
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

        public static IEnumerable<Bucket> Enumerate(User user) {
            return Program.db.Buckets.Where(x => x.User_ID == user.ID).OrderBy(x => x.Name);
        }

        public Bucket() { }
        public Bucket(User user) {
            this.User = user;
            this.User_ID = user.ID;
        }

        public Amount GetBalance(Bank bank = null) { return new Amount(bank, this); }

        public Bucket Rename(Pair val) {
            if (val != null) {
                bool changes = false;

                if (this.Description != val.Description) {
                    this.Description = val.Description;
                    changes = true;
                }

                if (this.Name != val.Name && val.Name != "") {
                    if (Program.db.Buckets.Where(x => x.User_ID == this.User_ID && x.Name == val.Name).Any()) {
                        throw new ValidationException("A bucket named \"" + val.Name + "\" already exists");
                    } else {
                        this.Name = val.Name;
                        changes = true;
                    }
                }

                if (changes) {
                    try {
                        if (this.ID == 0) { Program.db.Buckets.Add(this); }
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
