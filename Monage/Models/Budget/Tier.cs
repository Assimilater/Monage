using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monage.Models {
    public enum TierClass { Percentage, Amount }
    public class Tier {
        [Key]
        public int ID { get; set; }
        public int Order { get; set; }
        public TierClass Type { get; set; }
        public virtual Budget Budget { get; set; }
        public virtual List<Step> Steps { get; set; }
    }
}
