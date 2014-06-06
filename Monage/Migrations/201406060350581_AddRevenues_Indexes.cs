namespace Monage.Migrations {
    using System;
    using System.Data.Entity.Migrations;

    public partial class AddRevenues_Indexes : DbMigration {
        public override void Up() {
            CreateIndex("dbo.Revenues", new string[] { "Name", "User_ID" }, true, "Unique");
        }

        public override void Down() {
            DropIndex("dbo.Revenues", "Unique");
        }
    }
}
