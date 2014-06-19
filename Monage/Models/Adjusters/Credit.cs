using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monage.Models {
    public class Credit {
        #region Schema

        [Key]
        public int ID { get; set; }
        
        [Required]
        public double Amount { get; set; }
        public virtual Revenue Revenue { get; set; }

        [Required]
        public virtual Bank Bank { get; set; }
        public virtual Bucket Bucket { get; set; }

        #endregion

        public Credit() {
            Amount = 0;
        }
    }
}
