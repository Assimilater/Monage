namespace Monage.Migrations {
    using System;
    using System.Data.Entity.Migrations;

    public partial class AddRevenues : DbMigration {
        public override void Up() {
            CreateTable(
                "dbo.Revenues",
                c => new {
                    ID = c.Int(nullable: false, identity: true),
                    Name = c.String(nullable: false, maxLength: 45),
                    Description = c.String(),
                    User_ID = c.Int(),
                })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Users", t => t.User_ID)
                .Index(t => t.User_ID);

            AddColumn("dbo.Balances", "Amount_Confirmed", c => c.Double(nullable: false));
            AddColumn("dbo.Balances", "Amount_Expected", c => c.Double(nullable: false));
            AddColumn("dbo.Banks", "Other_Confirmed", c => c.Double(nullable: false));
            AddColumn("dbo.Banks", "Other_Expected", c => c.Double(nullable: false));
            DropColumn("dbo.Balances", "Amount_Physical");
            DropColumn("dbo.Balances", "Amount_Actual");
            DropColumn("dbo.Banks", "Other_Physical");
            DropColumn("dbo.Banks", "Other_Actual");
        }

        public override void Down() {
            AddColumn("dbo.Banks", "Other_Actual", c => c.Double(nullable: false));
            AddColumn("dbo.Banks", "Other_Physical", c => c.Double(nullable: false));
            AddColumn("dbo.Balances", "Amount_Actual", c => c.Double(nullable: false));
            AddColumn("dbo.Balances", "Amount_Physical", c => c.Double(nullable: false));
            DropForeignKey("dbo.Revenues", "User_ID", "dbo.Users");
            DropIndex("dbo.Revenues", new[] { "User_ID" });
            DropColumn("dbo.Banks", "Other_Expected");
            DropColumn("dbo.Banks", "Other_Confirmed");
            DropColumn("dbo.Balances", "Amount_Expected");
            DropColumn("dbo.Balances", "Amount_Confirmed");
            DropTable("dbo.Revenues");
        }
    }
}
