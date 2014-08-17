namespace Monage.Migrations {
    using System;
    using System.Data.Entity.Migrations;

    public partial class ConvertToDecimal : DbMigration {
        public override void Up() {
            AlterColumn("dbo.Steps", "Value", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Tickets", "Amount", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }

        public override void Down() {
            AlterColumn("dbo.Tickets", "Amount", c => c.Double(nullable: false));
            AlterColumn("dbo.Steps", "Value", c => c.Double(nullable: false));
        }
    }
}
