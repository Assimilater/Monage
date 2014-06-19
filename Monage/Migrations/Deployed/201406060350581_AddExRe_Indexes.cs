namespace Monage.Migrations {
    using System;
    using System.Data.Entity.Migrations;

    public partial class AddExRe_Indexes : DbMigration {
        public override void Up() {
            CreateIndex("dbo.Expenses", new string[] { "Name", "User_ID" }, true, "Unique");
            CreateIndex("dbo.Revenues", new string[] { "Name", "User_ID" }, true, "Unique");
        }

        public override void Down() {
            DropIndex("dbo.Expenses", "Unique");
            DropIndex("dbo.Revenues", "Unique");
        }
    }
}
