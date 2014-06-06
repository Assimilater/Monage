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

        public virtual Transaction Transaction { get; set; }
        public virtual Debit Debit { get; set; }
        public virtual Credit Credit { get; set; }

        #endregion

        public Ticket() {
            Debit = new Debit();
            Credit = new Credit();
        }
    }
}
