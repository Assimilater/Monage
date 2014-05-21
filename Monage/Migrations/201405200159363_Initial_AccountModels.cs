namespace Monage.Migrations {
    using System;
    using System.Data.Entity.Migrations;

    public partial class Initial_AccountModels : DbMigration {
        public override void Up() {
            CreateTable(
                "dbo.Balances",
                c => new {
                    ID = c.Int(nullable: false, identity: true),
                    Amount = c.Double(nullable: false),
                    Bank_ID = c.Int(),
                    Bucket_ID = c.Int(),
                })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Banks", t => t.Bank_ID)
                .ForeignKey("dbo.Buckets", t => t.Bucket_ID)
                .Index(t => t.Bank_ID)
                .Index(t => t.Bucket_ID);

            CreateTable(
                "dbo.Banks",
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
                "dbo.Users",
                c => new {
                    ID = c.Int(nullable: false, identity: true),
                    Username = c.String(nullable: false, maxLength: 45),
                })
                .PrimaryKey(t => t.ID);

            CreateTable(
                "dbo.Buckets",
                c => new {
                    ID = c.Int(nullable: false, identity: true),
                    Name = c.String(nullable: false, maxLength: 45),
                    Description = c.String(),
                    User_ID = c.Int(),
                })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Users", t => t.User_ID)
                .Index(t => t.User_ID);

            // Custom code
            CreateIndex("dbo.Users", "Username", true, "Unique");
            CreateIndex("dbo.Banks", new string[] { "Name", "User_ID" }, true, "Unique");
            CreateIndex("dbo.Buckets", new string[] { "Name", "User_ID" }, true, "Unique");
            CreateIndex("dbo.Balances", new string[] { "Bank_ID", "Bucket_ID" }, true, "Unique");
        }

        public override void Down() {
            DropForeignKey("dbo.Buckets", "User_ID", "dbo.Users");
            DropForeignKey("dbo.Balances", "Bucket_ID", "dbo.Buckets");
            DropForeignKey("dbo.Banks", "User_ID", "dbo.Users");
            DropForeignKey("dbo.Balances", "Bank_ID", "dbo.Banks");
            DropIndex("dbo.Buckets", new[] { "User_ID" });
            DropIndex("dbo.Banks", new[] { "User_ID" });
            DropIndex("dbo.Balances", new[] { "Bucket_ID" });
            DropIndex("dbo.Balances", new[] { "Bank_ID" });
            DropTable("dbo.Buckets");
            DropTable("dbo.Users");
            DropTable("dbo.Banks");
            DropTable("dbo.Balances");

            // Custom code
            DropIndex("dbo.Users", "Unique");
            DropIndex("dbo.Banks", "Unique");
            DropIndex("dbo.Buckets", "Unique");
            DropIndex("dbo.Balances", "Unique");
        }
    }
}
