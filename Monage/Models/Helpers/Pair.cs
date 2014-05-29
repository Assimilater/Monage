using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monage.Models {
    public class Pair {
        public string Name { get; set; }
        public string Description { get; set; }
        public Pair(string name, string description) {
            Name = name;
            Description = description;
        }
    }
}
