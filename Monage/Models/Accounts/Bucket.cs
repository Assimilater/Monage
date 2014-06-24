using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

        public virtual User User { get; set; }

        #endregion

        public static List<Bucket> Enumerate(User u) {
            return Program.db.Buckets.Where(x => x.User.ID == u.ID).OrderBy(x => x.Name).ToList();
        }

        public Bucket() { }
        public Bucket(User user) { User = user; }

        public Amount GetBalance(Bank b = null) { return new Amount(b, this); }

        public Bucket Rename(Pair val) {
            if (val != null) {
                bool changes = false;

                if (Description != val.Description) {
                    Description = val.Description;
                    changes = true;
                }

                if (Name != val.Name && val.Name != "") {
                    if (Program.db.Buckets.Where(x => x.User.ID == User.ID && x.Name == val.Name).Any()) {
                        throw new ValidationException("A bucket named \"" + val.Name + "\" already exists");
                    } else {
                        Name = val.Name;
                        changes = true;
                    }
                }

                if (changes) {
                    try {
                        if (ID == 0) { Program.db.Buckets.Add(this); }
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
