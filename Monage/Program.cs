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
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Load the application
            Splash s = new Splash();
            s.Show();

            // Give some (short) time for the splash to show
            Thread.Sleep(TimeSpan.FromSeconds(1));

            // Run Migrations
            Database.SetInitializer(
                new MigrateDatabaseToLatestVersion<Context, Configuration>()
            ); // TODO: Fix this...doesn't do anything?

            // Open database
            db = new Context();
            s.Close();

            // Start the application
            Host = new MDIHost();
            Application.Run(Host);
        }
    }
}
