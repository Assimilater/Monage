using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monage.Models {
    public enum TierClass { Ratio, Fixed }
    public class Tier {
        [Key]
        public int ID { get; set; }
        public int Order { get; set; }
        public TierClass Type { get; set; }

        [ForeignKey("Budget_ID")]
        public virtual Budget Budget { get; set; }
        public int Budget_ID { get; set; }

        public virtual List<Step> Steps { get; set; }

        [ForeignKey("User_ID")]
        public virtual User User { get; set; }
        public int User_ID { get; set; }

        public Tier() {
            Steps = new List<Step>();
        }
    }
}
