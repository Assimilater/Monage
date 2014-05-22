﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monage.Models {
    public class User {
        [Key]
        public int ID { get; set; }

        [Required]
        [MaxLength(Program.NameLen)]
        public string Username { get; set; }

        public virtual List<Bank> Banks { get; set; }
        public virtual List<Bucket> Buckets { get; set; }
        public virtual List<Budget> Budgets { get; set; }
    }
}
