using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monage.Models {
    public class Expense {
        #region Schema

        [Key]
        public int ID { get; set; }

        [Required]
        [MaxLength(Program.NameLen)]
        public string Name { get; set; }

        [MaxLength(Program.NameLen)]
        public string Category { get; set; }

        public virtual User User { get; set; }

        [Required]
        public bool TaxDeductible { get; set; }

        #endregion

        public Expense() {
            TaxDeductible = false;
        }
        public Expense(User user) {
            User = user;
            TaxDeductible = false;
        }
    }
}
