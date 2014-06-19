namespace Monage.Migrations {
    using System;
    using System.Data.Entity.Migrations;

    public partial class AddOtherDefault : DbMigration {
        public override void Up() {
            AddColumn("dbo.Banks", "Other_Physical", c => c.Double(nullable: false));
            AddColumn("dbo.Banks", "Other_Actual", c => c.Double(nullable: false));
        }

        public override void Down() {
            DropColumn("dbo.Banks", "Other_Actual");
            DropColumn("dbo.Banks", "Other_Physical");
        }
    }
}
