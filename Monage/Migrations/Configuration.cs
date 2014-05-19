namespace Monage.Migrations {
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Monage.Utilities.Context> {
        public Configuration() {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Monage.Utilities.Context context) {
            // Seeding does not make sense for this application
        }
    }
}
