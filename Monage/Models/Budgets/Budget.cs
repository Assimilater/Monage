using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monage.Models {
    public class Budget {
        #region Schema

        [Key]
        public int ID { get; set; }

        [Required]
        [MaxLength(Settings.NameLen)]
        public string Name { get; set; }
        
        public string Description { get; set; }

        public virtual User User { get; set; }
        public virtual Bucket Final { get; set; }
        public virtual List<Tier> Tiers { get; set; }

        #endregion

        public Budget() {
            Tiers = new List<Tier>();
        }
    }
}
