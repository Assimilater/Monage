using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monage.Models {
    public class Ticket {
        #region Schema

        [Key]
        public int ID { get; set; }

        [Required]
        public double Amount { get; set; }

        public string Company { get; set; }
        public virtual Fund Fund { get; set; }

        public virtual Bank Bank { get; set; }
        public virtual Bucket Bucket { get; set; }

        public virtual User User { get; set; }
        public virtual Transaction Transaction { get; set; }

        #endregion

        public Ticket() {
            Amount = 0;
        }
    }
}
