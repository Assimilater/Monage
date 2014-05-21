using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monage.Models {
    public class Bank {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual List<Balance> Balances { get; set; }
        public virtual User User { get; set; }
    }
}
