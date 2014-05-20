using Monage.GUI;
using Monage.GUI.Dialogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monage {
    static class Program {
        [STAThread]
        static void Main() {
            

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            int? userID = UserDialog.SelectUser();
            if (userID != null) {
                MainFrame window = new MainFrame();
                window.Open((int)userID);
                Application.Run(window);
            }
        }
    }
}
