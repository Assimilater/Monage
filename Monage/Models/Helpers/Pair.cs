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
            this.Name = name;
            this.Description = description;
        }
    }
    public class Trio {
        public string Name { get; set; }
        public string Description { get; set; }
        public Bucket Bucket { get; set; }
        public Trio(string name, string description, Bucket bucket) {
            this.Name = name;
            this.Description = description;
            this.Bucket = bucket;
        }
    }
}
