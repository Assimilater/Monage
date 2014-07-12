using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monage.Models {
    public class Step {
        [Key]
        public int ID { get; set; }
        public int Order { get; set; }
        public virtual Tier Tier { get; set; }
        public virtual Bucket Bucket { get; set; }
        public double Value { get; set; }

        public virtual User User { get; set; }
    }
}
