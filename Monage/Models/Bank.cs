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
        public double Balance { get; set; }
        public virtual List<Division> Divisions { get; set; }
        public virtual User User { get; set; }
    }
}
