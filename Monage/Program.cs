using Monage.GUI;
using Monage.Migrations;
using Monage.Utilities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monage {
    static class Program {
        [STAThread]
        static void Main() {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<Context, Configuration>());

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainFrame());
        }
    }
}
