using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monage.Models {
    public class Step {
        [Key]
        public int ID { get; set; }
        public int Order { get; set; }
        public double Value { get; set; }

        [ForeignKey("Tier_ID")]
        public virtual Tier Tier { get; set; }
        public int Tier_ID { get; set; }

        [ForeignKey("Bucket_ID")]
        public virtual Bucket Bucket { get; set; }
        public int Bucket_ID { get; set; }

        [ForeignKey("User_ID")]
        public virtual User User { get; set; }
        public int User_ID { get; set; }
    }
}
