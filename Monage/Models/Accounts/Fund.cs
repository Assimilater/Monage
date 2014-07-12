using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monage.Models {
    public enum BalanceType { Debit, Credit }
    public class Fund {
        #region Schema

        [Key]
        public int ID { get; set; }

        [Required]
        [MaxLength(Settings.NameLen)]
        public string Name { get; set; }
        public string Description { get; set; }
        public BalanceType BalanceType { get; set; }

        public virtual User User { get; set; }

        #endregion

        public static List<Fund> Enumerate(User u, BalanceType t) {
            return Program.db.Funds.Where(x => x.User.ID == u.ID && x.BalanceType == t).OrderBy(x => x.Name).ToList();
        }
    }
}
