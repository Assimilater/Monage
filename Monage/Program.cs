using Monage.GUI;
using Monage.Migrations;
using Monage.Utilities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monage {
    public static class Program {
        public const int NameLen = 45;
        public static MDIHost Host;
        public static Context db;

        [STAThread]
        public static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Load the application
            Splash s = new Splash();
            s.Show();

            // Set Migrations To Update DB on First Connection
            Database.SetInitializer(
                new MigrateDatabaseToLatestVersion<Context, Configuration>()
            );

            // Open database
            db = new Context();
            db.Users.FirstOrDefault(); // Make a call to db so migrations are triggered
            s.Close();                 // Close the splash screen

            // Start the application
            Host = new MDIHost();
            Application.Run(Host);
        }

        public static bool ConfirmClose(string con, string conf) {
            return DialogResult.Yes == MessageBox.Show(
                Host,
                con + ":\n" +
                    "You have unsaved changes.\n" +
                    "Are you sure you wish to close?",
                "Confirm " + conf,
                MessageBoxButtons.YesNo
            );
        }
    }
}
