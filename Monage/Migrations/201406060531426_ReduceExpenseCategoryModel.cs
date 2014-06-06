namespace Monage.Migrations {
    using System;
    using System.Data.Entity.Migrations;

    public partial class ReduceExpenseCategoryModel : DbMigration {
        public override void Up() {
            DropForeignKey("dbo.ExpenseCategories", "User_ID", "dbo.Users");
            DropForeignKey("dbo.Expenses", "Category_ID", "dbo.ExpenseCategories");
            DropIndex("dbo.Expenses", new[] { "Category_ID" });
            DropIndex("dbo.ExpenseCategories", new[] { "User_ID" });
            AddColumn("dbo.Expenses", "Category", c => c.String(maxLength: 45));
            DropColumn("dbo.Expenses", "Description");
            DropColumn("dbo.Expenses", "Category_ID");
            DropTable("dbo.ExpenseCategories");
        }

        public override void Down() {
            CreateTable(
                "dbo.ExpenseCategories",
                c => new {
                    ID = c.Int(nullable: false, identity: true),
                    Name = c.String(nullable: false, maxLength: 45),
                    Description = c.String(),
                    User_ID = c.Int(),
                })
                .PrimaryKey(t => t.ID);

            AddColumn("dbo.Expenses", "Category_ID", c => c.Int());
            AddColumn("dbo.Expenses", "Description", c => c.String());
            DropColumn("dbo.Expenses", "Category");
            CreateIndex("dbo.ExpenseCategories", "User_ID");
            CreateIndex("dbo.Expenses", "Category_ID");
            AddForeignKey("dbo.Expenses", "Category_ID", "dbo.ExpenseCategories", "ID");
            AddForeignKey("dbo.ExpenseCategories", "User_ID", "dbo.Users", "ID");
        }
    }
}
