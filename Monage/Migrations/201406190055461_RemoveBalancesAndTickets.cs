namespace Monage.Migrations {
    using System;
    using System.Data.Entity.Migrations;

    public partial class RemoveBalancesAndTickets : DbMigration {
        public override void Up() {
            DropForeignKey("dbo.Balances", "Bank_ID", "dbo.Banks");
            DropForeignKey("dbo.Balances", "Bucket_ID", "dbo.Buckets");
            DropForeignKey("dbo.Credits", "Account_ID", "dbo.Balances");
            DropForeignKey("dbo.Debits", "Account_ID", "dbo.Balances");
            DropForeignKey("dbo.Tickets", "Credit_ID", "dbo.Credits");
            DropForeignKey("dbo.Tickets", "Debit_ID", "dbo.Debits");
            DropForeignKey("dbo.Tickets", "Transaction_ID", "dbo.Transactions");
            DropIndex("dbo.Balances", new[] { "Bank_ID" });
            DropIndex("dbo.Balances", new[] { "Bucket_ID" });
            DropIndex("dbo.Credits", new[] { "Account_ID" });
            DropIndex("dbo.Debits", new[] { "Account_ID" });
            DropIndex("dbo.Tickets", new[] { "Credit_ID" });
            DropIndex("dbo.Tickets", new[] { "Debit_ID" });
            DropIndex("dbo.Tickets", new[] { "Transaction_ID" });
            AddColumn("dbo.Credits", "Bank_ID", c => c.Int(nullable: false));
            AddColumn("dbo.Credits", "Bucket_ID", c => c.Int());
            AddColumn("dbo.Credits", "Transaction_ID", c => c.Int());
            AddColumn("dbo.Debits", "Bank_ID", c => c.Int(nullable: false));
            AddColumn("dbo.Debits", "Bucket_ID", c => c.Int());
            AddColumn("dbo.Debits", "Transaction_ID", c => c.Int());
            CreateIndex("dbo.Credits", "Bank_ID");
            CreateIndex("dbo.Credits", "Bucket_ID");
            CreateIndex("dbo.Credits", "Transaction_ID");
            CreateIndex("dbo.Debits", "Bank_ID");
            CreateIndex("dbo.Debits", "Bucket_ID");
            CreateIndex("dbo.Debits", "Transaction_ID");
            AddForeignKey("dbo.Credits", "Bank_ID", "dbo.Banks", "ID", cascadeDelete: true);
            AddForeignKey("dbo.Credits", "Bucket_ID", "dbo.Buckets", "ID");
            AddForeignKey("dbo.Debits", "Bank_ID", "dbo.Banks", "ID", cascadeDelete: true);
            AddForeignKey("dbo.Debits", "Bucket_ID", "dbo.Buckets", "ID");
            AddForeignKey("dbo.Credits", "Transaction_ID", "dbo.Transactions", "ID");
            AddForeignKey("dbo.Debits", "Transaction_ID", "dbo.Transactions", "ID");
            DropColumn("dbo.Banks", "Other_Confirmed");
            DropColumn("dbo.Banks", "Other_Expected");
            DropColumn("dbo.Credits", "AccountBefore");
            DropColumn("dbo.Credits", "AccountAfter");
            DropColumn("dbo.Credits", "Account_ID");
            DropColumn("dbo.Debits", "AccountBefore");
            DropColumn("dbo.Debits", "AccountAfter");
            DropColumn("dbo.Debits", "Account_ID");
            DropTable("dbo.Balances");
            DropTable("dbo.Tickets");
        }

        public override void Down() {
            CreateTable(
                "dbo.Tickets",
                c => new {
                    ID = c.Int(nullable: false, identity: true),
                    Credit_ID = c.Int(),
                    Debit_ID = c.Int(),
                    Transaction_ID = c.Int(),
                })
                .PrimaryKey(t => t.ID);

            CreateTable(
                "dbo.Balances",
                c => new {
                    ID = c.Int(nullable: false, identity: true),
                    Amount_Confirmed = c.Double(nullable: false),
                    Amount_Expected = c.Double(nullable: false),
                    Bank_ID = c.Int(),
                    Bucket_ID = c.Int(),
                })
                .PrimaryKey(t => t.ID);

            AddColumn("dbo.Debits", "Account_ID", c => c.Int());
            AddColumn("dbo.Debits", "AccountAfter", c => c.Double());
            AddColumn("dbo.Debits", "AccountBefore", c => c.Double());
            AddColumn("dbo.Credits", "Account_ID", c => c.Int());
            AddColumn("dbo.Credits", "AccountAfter", c => c.Double());
            AddColumn("dbo.Credits", "AccountBefore", c => c.Double());
            AddColumn("dbo.Banks", "Other_Expected", c => c.Double(nullable: false));
            AddColumn("dbo.Banks", "Other_Confirmed", c => c.Double(nullable: false));
            DropForeignKey("dbo.Debits", "Transaction_ID", "dbo.Transactions");
            DropForeignKey("dbo.Credits", "Transaction_ID", "dbo.Transactions");
            DropForeignKey("dbo.Debits", "Bucket_ID", "dbo.Buckets");
            DropForeignKey("dbo.Debits", "Bank_ID", "dbo.Banks");
            DropForeignKey("dbo.Credits", "Bucket_ID", "dbo.Buckets");
            DropForeignKey("dbo.Credits", "Bank_ID", "dbo.Banks");
            DropIndex("dbo.Debits", new[] { "Transaction_ID" });
            DropIndex("dbo.Debits", new[] { "Bucket_ID" });
            DropIndex("dbo.Debits", new[] { "Bank_ID" });
            DropIndex("dbo.Credits", new[] { "Transaction_ID" });
            DropIndex("dbo.Credits", new[] { "Bucket_ID" });
            DropIndex("dbo.Credits", new[] { "Bank_ID" });
            DropColumn("dbo.Debits", "Transaction_ID");
            DropColumn("dbo.Debits", "Bucket_ID");
            DropColumn("dbo.Debits", "Bank_ID");
            DropColumn("dbo.Credits", "Transaction_ID");
            DropColumn("dbo.Credits", "Bucket_ID");
            DropColumn("dbo.Credits", "Bank_ID");
            CreateIndex("dbo.Tickets", "Transaction_ID");
            CreateIndex("dbo.Tickets", "Debit_ID");
            CreateIndex("dbo.Tickets", "Credit_ID");
            CreateIndex("dbo.Debits", "Account_ID");
            CreateIndex("dbo.Credits", "Account_ID");
            CreateIndex("dbo.Balances", "Bucket_ID");
            CreateIndex("dbo.Balances", "Bank_ID");
            AddForeignKey("dbo.Tickets", "Transaction_ID", "dbo.Transactions", "ID");
            AddForeignKey("dbo.Tickets", "Debit_ID", "dbo.Debits", "ID");
            AddForeignKey("dbo.Tickets", "Credit_ID", "dbo.Credits", "ID");
            AddForeignKey("dbo.Debits", "Account_ID", "dbo.Balances", "ID");
            AddForeignKey("dbo.Credits", "Account_ID", "dbo.Balances", "ID");
            AddForeignKey("dbo.Balances", "Bucket_ID", "dbo.Buckets", "ID");
            AddForeignKey("dbo.Balances", "Bank_ID", "dbo.Banks", "ID");
        }
    }
}
