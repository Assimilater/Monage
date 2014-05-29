﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monage.Models {
    public class Bank {
        [Key]
        public int ID { get; set; }

        [Required]
        [MaxLength(Program.NameLen)]
        public string Name { get; set; }

        public string Description { get; set; }
        public virtual List<Balance> Balances { get; set; }
        public virtual User User { get; set; }

        public Amount Other { get; set; }

        public Amount Balance() { return new Amount(this, this.Other); }

        public Bank Rename(String name) {
            if (Name != name && name != null && name != "") {
                if (Program.db.Banks.Where(x => x.User.ID == User.ID && x.Name == name).Any()) {
                    throw new ValidationException("A bank named \"" + name + "\" already exists");
                } else {
                    try {
                        Name = name;
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
