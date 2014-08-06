using Monage.GUI;
using Monage.Migrations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monage {
    public static class Program {
        public static Host Host;

        [STAThread]
        public static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Show the splash screen
            Splash s = new Splash();
            s.Show();

            // Run migrations and open a database connection
            new MigrateDatabaseToLatestVersion<Context, Configuration>()
                .InitializeDatabase(Session.Start());

            // Close the splash screen
            s.Close();

            // Start the application
            Application.Run(Host = new Host());
        }

        public static bool ConfirmReady(string action) {
            return DialogResult.Yes == MessageBox.Show(Program.Host,
                "You have unsaved changes.\n" +
                "These changes will be lost.\n" +
                "Are you sure you wish to proceed?",
                "Confirm " + action,
                MessageBoxButtons.YesNo
            );
        }
    }
}
