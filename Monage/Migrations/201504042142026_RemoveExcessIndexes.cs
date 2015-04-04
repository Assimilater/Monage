namespace Monage.Migrations {
    using System;
    using System.Data.Entity.Migrations;

    public partial class RemoveExcessIndexes : DbMigration {
        public override void Up() {
            DropForeignKey("dbo.Steps", "User_ID", "dbo.Users");
            DropForeignKey("dbo.Tiers", "User_ID", "dbo.Users");
            DropForeignKey("dbo.Tickets", "User_ID", "dbo.Users");
            DropIndex("dbo.Tiers", new[] { "User_ID" });
            DropIndex("dbo.Steps", new[] { "User_ID" });
            DropIndex("dbo.Tickets", new[] { "User_ID" });
            DropColumn("dbo.Tiers", "User_ID");
            DropColumn("dbo.Steps", "User_ID");
            DropColumn("dbo.Tickets", "User_ID");
        }

        public override void Down() {
            AddColumn("dbo.Tickets", "User_ID", c => c.Int(nullable: false));
            AddColumn("dbo.Steps", "User_ID", c => c.Int(nullable: false));
            AddColumn("dbo.Tiers", "User_ID", c => c.Int(nullable: false));
            CreateIndex("dbo.Tickets", "User_ID");
            CreateIndex("dbo.Steps", "User_ID");
            CreateIndex("dbo.Tiers", "User_ID");
            AddForeignKey("dbo.Tickets", "User_ID", "dbo.Users", "ID", cascadeDelete: true);
            AddForeignKey("dbo.Tiers", "User_ID", "dbo.Users", "ID", cascadeDelete: true);
            AddForeignKey("dbo.Steps", "User_ID", "dbo.Users", "ID", cascadeDelete: true);
        }
    }
}
