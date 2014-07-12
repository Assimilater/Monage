namespace Monage.Migrations {
    using System;
    using System.Data.Entity.Migrations;

    public partial class ReplaceExReWithFunds : DbMigration {
        public override void Up() {
            RenameTable(name: "dbo.Revenues", newName: "Funds");
            DropForeignKey("dbo.Expenses", "User_ID", "dbo.Users");
            DropForeignKey("dbo.Credits", "Revenue_ID", "dbo.Revenues");
            DropForeignKey("dbo.Debits", "Expense_ID", "dbo.Expenses");
            DropIndex("dbo.Credits", new[] { "Revenue_ID" });
            DropIndex("dbo.Debits", new[] { "Expense_ID" });
            DropIndex("dbo.Expenses", new[] { "User_ID" });
            AddColumn("dbo.Credits", "Company", c => c.String());
            AddColumn("dbo.Funds", "BalanceType", c => c.Int(nullable: false));
            AddColumn("dbo.Debits", "Company", c => c.String());
            AlterColumn("dbo.Credits", "Revenue_ID", c => c.Int(nullable: false));
            AlterColumn("dbo.Debits", "Expense_ID", c => c.Int(nullable: false));
            CreateIndex("dbo.Credits", "Revenue_ID");
            CreateIndex("dbo.Debits", "Expense_ID");
            AddForeignKey("dbo.Credits", "Revenue_ID", "dbo.Funds", "ID", cascadeDelete: true);
            AddForeignKey("dbo.Debits", "Expense_ID", "dbo.Funds", "ID", cascadeDelete: true);
            DropTable("dbo.Expenses");
        }

        public override void Down() {
            CreateTable(
                "dbo.Expenses",
                c => new {
                    ID = c.Int(nullable: false, identity: true),
                    Name = c.String(nullable: false, maxLength: 45),
                    Category = c.String(maxLength: 45),
                    TaxDeductible = c.Boolean(nullable: false),
                    User_ID = c.Int(),
                })
                .PrimaryKey(t => t.ID);

            DropForeignKey("dbo.Debits", "Expense_ID", "dbo.Funds");
            DropForeignKey("dbo.Credits", "Revenue_ID", "dbo.Funds");
            DropIndex("dbo.Debits", new[] { "Expense_ID" });
            DropIndex("dbo.Credits", new[] { "Revenue_ID" });
            AlterColumn("dbo.Debits", "Expense_ID", c => c.Int());
            AlterColumn("dbo.Credits", "Revenue_ID", c => c.Int());
            DropColumn("dbo.Debits", "Company");
            DropColumn("dbo.Funds", "BalanceType");
            DropColumn("dbo.Credits", "Company");
            CreateIndex("dbo.Expenses", "User_ID");
            CreateIndex("dbo.Debits", "Expense_ID");
            CreateIndex("dbo.Credits", "Revenue_ID");
            AddForeignKey("dbo.Debits", "Expense_ID", "dbo.Expenses", "ID");
            AddForeignKey("dbo.Credits", "Revenue_ID", "dbo.Revenues", "ID");
            AddForeignKey("dbo.Expenses", "User_ID", "dbo.Users", "ID");
            RenameTable(name: "dbo.Funds", newName: "Revenues");
        }
    }
}
