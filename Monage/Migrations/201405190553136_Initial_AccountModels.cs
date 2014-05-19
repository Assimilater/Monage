namespace Monage.Migrations {
    using System;
    using System.Data.Entity.Migrations;

    public partial class Initial_AccountModels : DbMigration {
        public override void Up() {
            CreateTable(
                "dbo.Accounts",
                c => new {
                    ID = c.Int(nullable: false, identity: true),
                    Name = c.String(maxLength: 4000),
                    Description = c.String(maxLength: 4000),
                    AccountType = c.Int(nullable: false),
                    TaxDeductible = c.Boolean(nullable: false),
                })
                .PrimaryKey(t => t.ID);

            CreateTable(
                "dbo.Banks",
                c => new {
                    ID = c.Int(nullable: false, identity: true),
                    Name = c.String(maxLength: 4000),
                    Balance = c.Double(nullable: false),
                    User_ID = c.Int(),
                })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Users", t => t.User_ID)
                .Index(t => t.User_ID);

            CreateTable(
                "dbo.Divisions",
                c => new {
                    ID = c.Int(nullable: false, identity: true),
                    Balance = c.Double(nullable: false),
                    Bank_ID = c.Int(),
                    Bucket_ID = c.Int(),
                })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Banks", t => t.Bank_ID)
                .ForeignKey("dbo.Buckets", t => t.Bucket_ID)
                .Index(t => t.Bank_ID)
                .Index(t => t.Bucket_ID);

            CreateTable(
                "dbo.Buckets",
                c => new {
                    ID = c.Int(nullable: false, identity: true),
                    Name = c.String(maxLength: 4000),
                    Description = c.String(maxLength: 4000),
                    User_ID = c.Int(),
                })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Users", t => t.User_ID)
                .Index(t => t.User_ID);

            CreateTable(
                "dbo.Users",
                c => new {
                    ID = c.Int(nullable: false, identity: true),
                    Username = c.String(maxLength: 4000),
                })
                .PrimaryKey(t => t.ID);

            // Custom code
            CreateIndex("dbo.Users", "Username", true, "Unique");
            CreateIndex("dbo.Banks", new string[] { "Name", "User_ID" }, true, "Unique");
            CreateIndex("dbo.Buckets", new string[] { "Name", "User_ID" }, true, "Unique");
            CreateIndex("dbo.Divisions", new string[] { "Bank_ID", "Bucket_ID" }, true, "Unique");
        }

        public override void Down() {
            DropForeignKey("dbo.Divisions", "Bucket_ID", "dbo.Buckets");
            DropForeignKey("dbo.Buckets", "User_ID", "dbo.Users");
            DropForeignKey("dbo.Banks", "User_ID", "dbo.Users");
            DropForeignKey("dbo.Divisions", "Bank_ID", "dbo.Banks");
            DropIndex("dbo.Buckets", new[] { "User_ID" });
            DropIndex("dbo.Divisions", new[] { "Bucket_ID" });
            DropIndex("dbo.Divisions", new[] { "Bank_ID" });
            DropIndex("dbo.Banks", new[] { "User_ID" });
            DropTable("dbo.Users");
            DropTable("dbo.Buckets");
            DropTable("dbo.Divisions");
            DropTable("dbo.Banks");
            DropTable("dbo.Accounts");

            // Custom code
            DropIndex("dbo.Users", "Unique");
            DropIndex("dbo.Banks", "Unique");
            DropIndex("dbo.Buckets", "Unique");
            DropIndex("dbo.Divisions", "Unique");
        }
    }
}
