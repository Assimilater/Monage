using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace Monage {
    public class Settings {
        private static RegistryKey Reg {
            get { return Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("Monage"); }
        }

        #region Constants
        
        public const int NameLen = 45;


        #endregion

        #region RegistryValues
        
        public static int ActiveUser {
            get { return (int)Reg.GetValue("ActiveUser", -1); }
            set { Reg.SetValue("ActiveUser", value); }
        }
        public static bool Maximized {
            get { return (bool)Reg.GetValue("Maximized", false); }
            set { Reg.SetValue("Maximized", value); }
        }

        #endregion
    }
}
