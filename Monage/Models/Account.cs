using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monage {
    public enum AccountType { Asset, Liability, Equity }
    public class Account {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public AccountType AccountType { get; set; }
        public bool TaxDeductible { get; set; }

        public Account() {
            // Default values
            TaxDeductible = false;

        }
    }
}
