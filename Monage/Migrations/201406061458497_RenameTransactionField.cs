namespace Monage.Migrations {
    using System;
    using System.Data.Entity.Migrations;

    public partial class RenameTransactionField : DbMigration {
        public override void Up() {
            AddColumn("dbo.Transactions", "Incurred", c => c.DateTime(nullable: false));
            DropColumn("dbo.Transactions", "Created");
        }

        public override void Down() {
            AddColumn("dbo.Transactions", "Created", c => c.DateTime(nullable: false));
            DropColumn("dbo.Transactions", "Incurred");
        }
    }
}
