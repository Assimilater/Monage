using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monage.Models {
    public class Balance {
        [Key]
        public int ID { get; set; }
        public Amount Amount { get; set; }
        public virtual Bank Bank { get; set; }
        public virtual Bucket Bucket { get; set; }
    }
}
