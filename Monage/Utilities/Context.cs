using Monage.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monage {
    public class Context : DbContext {
        public Context() : base("Monage") { }

        public DbSet<User> Users { get; set; }

        public DbSet<Bank> Banks { get; set; }
        public DbSet<Bucket> Buckets { get; set; }

        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Fund> Funds { get; set; }

        //public DbSet<Budget> Budgets { get; set; }
        //public DbSet<Tier> Tiers { get; set; }
        //public DbSet<Step> Step { get; set; }
    }
}
