using Monage.GUI;
using Monage.Migrations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monage {
    public static class Program {
        public static Shell Window;

        [STAThread]
        public static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Show the splash screen
            Splash s = new Splash();
            s.Show();

            // Run migrations and open a database connection
            var Initializer = new MigrateDatabaseToLatestVersion<Context, Configuration>();
            Database.SetInitializer(Initializer);
            Initializer.InitializeDatabase(Session.Start());
            DbMigrator dbMigrator = new DbMigrator(new Configuration());
            dbMigrator.Update();

            // Close the splash screen  
            s.Close();

            // Start the application
            Application.Run(Window = new Shell());
        }

        public static bool ConfirmReady(string action) {
            return DialogResult.Yes == MessageBox.Show(Program.Window,
                "You have unsaved changes.\n" +
                "These changes will be lost.\n" +
                "Are you sure you wish to proceed?",
                "Confirm " + action,
                MessageBoxButtons.YesNo
            );
        }
    }
}
