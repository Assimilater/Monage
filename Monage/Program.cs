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
        public static MDIHost Host;
        public static Context db;

        [STAThread]
        public static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Show the splash screen
            Splash s = new Splash();
            s.Show();

            // Run Migrations and Establish Database Connection
            new MigrateDatabaseToLatestVersion<Context, Configuration>()
                .InitializeDatabase(Program.db = new Context());
            
            // Close the splash screen
            s.Close();

            // Start the application
            Host = new MDIHost();
            Application.Run(Host);
        }

        public static bool ConfirmReady(string con, string conf) {
            return DialogResult.Yes == MessageBox.Show(
                Host,
                con + ":\n" +
                    "You have unsaved changes.\n" +
                    "These changes will be lost.\n" +
                    "Are you sure you wish to proceed?",
                "Confirm " + conf,
                MessageBoxButtons.YesNo
            );
        }
    }
}
