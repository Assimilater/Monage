using Monage.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monage.Utilities {
    public class Context : DbContext {
        public Context() : base("Monage") { }

        public DbSet<User> Users { get; set; }

        public DbSet<Bank> Banks { get; set; }
        public DbSet<Bucket> Buckets { get; set; }
        public DbSet<Balance> Balances { get; set; }
        
        public DbSet<Revenue> Revenues { get; set; }
        public DbSet<Expense> Expenses { get; set; }
        public DbSet<ExpenseCategory> ExpenseCategories { get; set; }
    }
}
