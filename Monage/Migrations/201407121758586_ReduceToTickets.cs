namespace Monage.Migrations {
    using System;
    using System.Data.Entity.Migrations;

    public partial class ReduceToTickets : DbMigration {
        public override void Up() {
            DropForeignKey("dbo.Credits", "Bank_ID", "dbo.Banks");
            DropForeignKey("dbo.Credits", "Bucket_ID", "dbo.Buckets");
            DropForeignKey("dbo.Credits", "Revenue_ID", "dbo.Funds");
            DropForeignKey("dbo.Debits", "Bank_ID", "dbo.Banks");
            DropForeignKey("dbo.Debits", "Bucket_ID", "dbo.Buckets");
            DropForeignKey("dbo.Debits", "Expense_ID", "dbo.Funds");
            DropForeignKey("dbo.Credits", "Transaction_ID", "dbo.Transactions");
            DropForeignKey("dbo.Debits", "Transaction_ID", "dbo.Transactions");
            DropIndex("dbo.Credits", new[] { "Bank_ID" });
            DropIndex("dbo.Credits", new[] { "Bucket_ID" });
            DropIndex("dbo.Credits", new[] { "Revenue_ID" });
            DropIndex("dbo.Credits", new[] { "Transaction_ID" });
            DropIndex("dbo.Debits", new[] { "Bank_ID" });
            DropIndex("dbo.Debits", new[] { "Bucket_ID" });
            DropIndex("dbo.Debits", new[] { "Expense_ID" });
            DropIndex("dbo.Debits", new[] { "Transaction_ID" });
            CreateTable(
                "dbo.Tickets",
                c => new {
                    ID = c.Int(nullable: false, identity: true),
                    Amount = c.Double(nullable: false),
                    Company = c.String(),
                    Bank_ID = c.Int(),
                    Bucket_ID = c.Int(),
                    Fund_ID = c.Int(),
                    Transaction_ID = c.Int(),
                    User_ID = c.Int(),
                })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Banks", t => t.Bank_ID)
                .ForeignKey("dbo.Buckets", t => t.Bucket_ID)
                .ForeignKey("dbo.Funds", t => t.Fund_ID)
                .ForeignKey("dbo.Transactions", t => t.Transaction_ID)
                .ForeignKey("dbo.Users", t => t.User_ID)
                .Index(t => t.Bank_ID)
                .Index(t => t.Bucket_ID)
                .Index(t => t.Fund_ID)
                .Index(t => t.Transaction_ID)
                .Index(t => t.User_ID);

            AddColumn("dbo.Tiers", "User_ID", c => c.Int());
            AddColumn("dbo.Steps", "User_ID", c => c.Int());
            AddColumn("dbo.Transactions", "User_ID", c => c.Int());
            CreateIndex("dbo.Tiers", "User_ID");
            CreateIndex("dbo.Steps", "User_ID");
            CreateIndex("dbo.Transactions", "User_ID");
            AddForeignKey("dbo.Steps", "User_ID", "dbo.Users", "ID");
            AddForeignKey("dbo.Tiers", "User_ID", "dbo.Users", "ID");
            AddForeignKey("dbo.Transactions", "User_ID", "dbo.Users", "ID");
            DropTable("dbo.Credits");
            DropTable("dbo.Debits");
        }

        public override void Down() {
            CreateTable(
                "dbo.Debits",
                c => new {
                    ID = c.Int(nullable: false, identity: true),
                    Amount = c.Double(nullable: false),
                    Company = c.String(),
                    Bank_ID = c.Int(nullable: false),
                    Bucket_ID = c.Int(),
                    Expense_ID = c.Int(nullable: false),
                    Transaction_ID = c.Int(),
                })
                .PrimaryKey(t => t.ID);

            CreateTable(
                "dbo.Credits",
                c => new {
                    ID = c.Int(nullable: false, identity: true),
                    Amount = c.Double(nullable: false),
                    Company = c.String(),
                    Bank_ID = c.Int(nullable: false),
                    Bucket_ID = c.Int(),
                    Revenue_ID = c.Int(nullable: false),
                    Transaction_ID = c.Int(),
                })
                .PrimaryKey(t => t.ID);

            DropForeignKey("dbo.Tickets", "User_ID", "dbo.Users");
            DropForeignKey("dbo.Transactions", "User_ID", "dbo.Users");
            DropForeignKey("dbo.Tickets", "Transaction_ID", "dbo.Transactions");
            DropForeignKey("dbo.Tickets", "Fund_ID", "dbo.Funds");
            DropForeignKey("dbo.Tickets", "Bucket_ID", "dbo.Buckets");
            DropForeignKey("dbo.Tickets", "Bank_ID", "dbo.Banks");
            DropForeignKey("dbo.Tiers", "User_ID", "dbo.Users");
            DropForeignKey("dbo.Steps", "User_ID", "dbo.Users");
            DropIndex("dbo.Transactions", new[] { "User_ID" });
            DropIndex("dbo.Tickets", new[] { "User_ID" });
            DropIndex("dbo.Tickets", new[] { "Transaction_ID" });
            DropIndex("dbo.Tickets", new[] { "Fund_ID" });
            DropIndex("dbo.Tickets", new[] { "Bucket_ID" });
            DropIndex("dbo.Tickets", new[] { "Bank_ID" });
            DropIndex("dbo.Steps", new[] { "User_ID" });
            DropIndex("dbo.Tiers", new[] { "User_ID" });
            DropColumn("dbo.Transactions", "User_ID");
            DropColumn("dbo.Steps", "User_ID");
            DropColumn("dbo.Tiers", "User_ID");
            DropTable("dbo.Tickets");
            CreateIndex("dbo.Debits", "Transaction_ID");
            CreateIndex("dbo.Debits", "Expense_ID");
            CreateIndex("dbo.Debits", "Bucket_ID");
            CreateIndex("dbo.Debits", "Bank_ID");
            CreateIndex("dbo.Credits", "Transaction_ID");
            CreateIndex("dbo.Credits", "Revenue_ID");
            CreateIndex("dbo.Credits", "Bucket_ID");
            CreateIndex("dbo.Credits", "Bank_ID");
            AddForeignKey("dbo.Debits", "Transaction_ID", "dbo.Transactions", "ID");
            AddForeignKey("dbo.Credits", "Transaction_ID", "dbo.Transactions", "ID");
            AddForeignKey("dbo.Debits", "Expense_ID", "dbo.Funds", "ID", cascadeDelete: true);
            AddForeignKey("dbo.Debits", "Bucket_ID", "dbo.Buckets", "ID");
            AddForeignKey("dbo.Debits", "Bank_ID", "dbo.Banks", "ID", cascadeDelete: true);
            AddForeignKey("dbo.Credits", "Revenue_ID", "dbo.Funds", "ID", cascadeDelete: true);
            AddForeignKey("dbo.Credits", "Bucket_ID", "dbo.Buckets", "ID");
            AddForeignKey("dbo.Credits", "Bank_ID", "dbo.Banks", "ID", cascadeDelete: true);
        }
    }
}
