namespace Monage.Migrations {
    using System;
    using System.Data.Entity.Migrations;

    public partial class AddAmount : DbMigration {
        public override void Up() {
            AddColumn("dbo.Balances", "Amount_Physical", c => c.Double(nullable: false));
            AddColumn("dbo.Balances", "Amount_Actual", c => c.Double(nullable: false));
            DropColumn("dbo.Balances", "Amount");
        }

        public override void Down() {
            AddColumn("dbo.Balances", "Amount", c => c.Double(nullable: false));
            DropColumn("dbo.Balances", "Amount_Actual");
            DropColumn("dbo.Balances", "Amount_Physical");
        }
    }
}
