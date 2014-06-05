namespace Monage.Migrations {
    using System;
    using System.Data.Entity.Migrations;

    public partial class AddExpenses : DbMigration {
        public override void Up() {
            CreateTable(
                "dbo.ExpenseCategories",
                c => new {
                    ID = c.Int(nullable: false, identity: true),
                    Name = c.String(nullable: false, maxLength: 45),
                    Description = c.String(),
                    User_ID = c.Int(),
                })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Users", t => t.User_ID)
                .Index(t => t.User_ID);

            CreateTable(
                "dbo.Expenses",
                c => new {
                    ID = c.Int(nullable: false, identity: true),
                    Name = c.String(nullable: false, maxLength: 45),
                    Description = c.String(),
                    TaxDeductible = c.Boolean(nullable: false),
                    Category_ID = c.Int(),
                    User_ID = c.Int(),
                })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.ExpenseCategories", t => t.Category_ID)
                .ForeignKey("dbo.Users", t => t.User_ID)
                .Index(t => t.Category_ID)
                .Index(t => t.User_ID);
        }

        public override void Down() {
            DropForeignKey("dbo.Expenses", "User_ID", "dbo.Users");
            DropForeignKey("dbo.Expenses", "Category_ID", "dbo.ExpenseCategories");
            DropForeignKey("dbo.ExpenseCategories", "User_ID", "dbo.Users");
            DropIndex("dbo.Expenses", new[] { "User_ID" });
            DropIndex("dbo.Expenses", new[] { "Category_ID" });
            DropIndex("dbo.ExpenseCategories", new[] { "User_ID" });
            DropTable("dbo.Expenses");
            DropTable("dbo.ExpenseCategories");
        }
    }
}
