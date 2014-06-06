namespace Monage.Migrations {
    using System;
    using System.Data.Entity.Migrations;

    public partial class AddTransactions : DbMigration {
        public override void Up() {
            CreateTable(
                "dbo.Credits",
                c => new {
                    ID = c.Int(nullable: false, identity: true),
                    Amount = c.Double(nullable: false),
                    AccountBefore = c.Double(),
                    AccountAfter = c.Double(),
                    Account_ID = c.Int(),
                    Revenue_ID = c.Int(),
                })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Balances", t => t.Account_ID)
                .ForeignKey("dbo.Revenues", t => t.Revenue_ID)
                .Index(t => t.Account_ID)
                .Index(t => t.Revenue_ID);

            CreateTable(
                "dbo.Debits",
                c => new {
                    ID = c.Int(nullable: false, identity: true),
                    Amount = c.Double(nullable: false),
                    AccountBefore = c.Double(),
                    AccountAfter = c.Double(),
                    Account_ID = c.Int(),
                    Expense_ID = c.Int(),
                })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Balances", t => t.Account_ID)
                .ForeignKey("dbo.Expenses", t => t.Expense_ID)
                .Index(t => t.Account_ID)
                .Index(t => t.Expense_ID);

            CreateTable(
                "dbo.Tickets",
                c => new {
                    ID = c.Int(nullable: false, identity: true),
                    Credit_ID = c.Int(),
                    Debit_ID = c.Int(),
                    Transaction_ID = c.Int(),
                })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Credits", t => t.Credit_ID)
                .ForeignKey("dbo.Debits", t => t.Debit_ID)
                .ForeignKey("dbo.Transactions", t => t.Transaction_ID)
                .Index(t => t.Credit_ID)
                .Index(t => t.Debit_ID)
                .Index(t => t.Transaction_ID);

            CreateTable(
                "dbo.Transactions",
                c => new {
                    ID = c.Int(nullable: false, identity: true),
                    Brief = c.String(nullable: false, maxLength: 45),
                    Details = c.String(),
                    Created = c.DateTime(nullable: false),
                    Confirmed = c.DateTime(),
                })
                .PrimaryKey(t => t.ID);

        }

        public override void Down() {
            DropForeignKey("dbo.Tickets", "Transaction_ID", "dbo.Transactions");
            DropForeignKey("dbo.Tickets", "Debit_ID", "dbo.Debits");
            DropForeignKey("dbo.Tickets", "Credit_ID", "dbo.Credits");
            DropForeignKey("dbo.Debits", "Expense_ID", "dbo.Expenses");
            DropForeignKey("dbo.Debits", "Account_ID", "dbo.Balances");
            DropForeignKey("dbo.Credits", "Revenue_ID", "dbo.Revenues");
            DropForeignKey("dbo.Credits", "Account_ID", "dbo.Balances");
            DropIndex("dbo.Tickets", new[] { "Transaction_ID" });
            DropIndex("dbo.Tickets", new[] { "Debit_ID" });
            DropIndex("dbo.Tickets", new[] { "Credit_ID" });
            DropIndex("dbo.Debits", new[] { "Expense_ID" });
            DropIndex("dbo.Debits", new[] { "Account_ID" });
            DropIndex("dbo.Credits", new[] { "Revenue_ID" });
            DropIndex("dbo.Credits", new[] { "Account_ID" });
            DropTable("dbo.Transactions");
            DropTable("dbo.Tickets");
            DropTable("dbo.Debits");
            DropTable("dbo.Credits");
        }
    }
}
