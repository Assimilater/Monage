namespace Monage.Migrations {
    using System;
    using System.Data.Entity.Migrations;

    public partial class AddExpenses_Indexes : DbMigration {
        public override void Up() {
            CreateIndex("dbo.Expenses", new string[] { "Name", "Category_ID", "User_ID" }, true, "Unique");
            CreateIndex("dbo.ExpenseCategories", new string[] { "Name", "User_ID" }, true, "Unique");
        }

        public override void Down() {
            DropIndex("dbo.Expenses", "Unique");
            DropIndex("dbo.ExpenseCategories", "Unique");
        }
    }
}
