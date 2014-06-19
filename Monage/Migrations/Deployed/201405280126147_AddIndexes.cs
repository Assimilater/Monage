namespace Monage.Migrations {
    using System;
    using System.Data.Entity.Migrations;

    public partial class AddIndexes : DbMigration {
        public override void Up() {
            CreateIndex("dbo.Users", "Username", true, "Unique");
            CreateIndex("dbo.Banks", new string[] { "Name", "User_ID" }, true, "Unique");
            CreateIndex("dbo.Buckets", new string[] { "Name", "User_ID" }, true, "Unique");
            CreateIndex("dbo.Budgets", new string[] { "Name", "User_ID" }, true, "Unique");
        }

        public override void Down() {
            DropIndex("dbo.Users", "Unique");
            DropIndex("dbo.Banks", "Unique");
            DropIndex("dbo.Buckets", "Unique");
            DropIndex("dbo.Budgets", "Unique");
        }
    }
}
