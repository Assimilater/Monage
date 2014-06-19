namespace Monage.Migrations {
    using System;
    using System.Data.Entity.Migrations;

    public partial class Initial_BudgetModels : DbMigration {
        public override void Up() {
            CreateTable(
                "dbo.Budgets",
                c => new {
                    ID = c.Int(nullable: false, identity: true),
                    Name = c.String(nullable: false, maxLength: 45),
                    Description = c.String(),
                    Final_ID = c.Int(),
                    User_ID = c.Int(),
                })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Buckets", t => t.Final_ID)
                .ForeignKey("dbo.Users", t => t.User_ID)
                .Index(t => t.Final_ID)
                .Index(t => t.User_ID);

            CreateTable(
                "dbo.Tiers",
                c => new {
                    ID = c.Int(nullable: false, identity: true),
                    Order = c.Int(nullable: false),
                    Type = c.Int(nullable: false),
                    Budget_ID = c.Int(),
                })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Budgets", t => t.Budget_ID)
                .Index(t => t.Budget_ID);

            CreateTable(
                "dbo.Steps",
                c => new {
                    ID = c.Int(nullable: false, identity: true),
                    Order = c.Int(nullable: false),
                    Value = c.Double(nullable: false),
                    Bucket_ID = c.Int(),
                    Tier_ID = c.Int(),
                })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Buckets", t => t.Bucket_ID)
                .ForeignKey("dbo.Tiers", t => t.Tier_ID)
                .Index(t => t.Bucket_ID)
                .Index(t => t.Tier_ID);
        }

        public override void Down() {
            DropForeignKey("dbo.Budgets", "User_ID", "dbo.Users");
            DropForeignKey("dbo.Steps", "Tier_ID", "dbo.Tiers");
            DropForeignKey("dbo.Steps", "Bucket_ID", "dbo.Buckets");
            DropForeignKey("dbo.Tiers", "Budget_ID", "dbo.Budgets");
            DropForeignKey("dbo.Budgets", "Final_ID", "dbo.Buckets");
            DropIndex("dbo.Steps", new[] { "Tier_ID" });
            DropIndex("dbo.Steps", new[] { "Bucket_ID" });
            DropIndex("dbo.Tiers", new[] { "Budget_ID" });
            DropIndex("dbo.Budgets", new[] { "User_ID" });
            DropIndex("dbo.Budgets", new[] { "Final_ID" });
            AlterColumn("dbo.Buckets", "Name", c => c.String());
            AlterColumn("dbo.Users", "Username", c => c.String());
            AlterColumn("dbo.Banks", "Name", c => c.String());
            DropTable("dbo.Steps");
            DropTable("dbo.Tiers");
            DropTable("dbo.Budgets");
        }
    }
}
