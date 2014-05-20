using Monage.GUI;
using Monage.GUI.Dialogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monage {
    static class Program {
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Load the application
            Splash s = new Splash();
            s.Show();

            Thread.Sleep(TimeSpan.FromSeconds(1));
            // Run Migrations

            s.Close();

            // Request user login
            int? userID = UserDialog.SelectUser();
            if (userID != null) {
                MainFrame window = new MainFrame();
                window.Open((int)userID);

                // Start the application
                Application.Run(window);
            }
        }
    }
}
