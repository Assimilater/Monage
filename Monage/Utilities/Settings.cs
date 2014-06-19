using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;
using System.Drawing;

namespace Monage {
    public class Settings {
        #region Constants

        public const int NameLen = 45;

        // Registry 'null' (aka default) values to compare against
        public const int NullInt = -int.MaxValue;
        public const string NullString = "";
        
        #endregion

        #region RegistryValues
        private static class Reg {
            public static RegistryKey Key() {
                return
                    Registry.CurrentUser
                        .CreateSubKey("Software")
                            .CreateSubKey("Monage");
            }

            public static object GetValue(string name, object def) {
                return Key().GetValue(name, def);
            }
            public static void SetValue(string name, object val) {
                Key().SetValue(name, val);
            }

            public static int GetInt(string name, int def = NullInt) {
                return (int)Key().GetValue(name, def);
            }
            public static void SetInt(string name, int val) {
                Key().SetValue(name, val);
            }

            public static string GetString(string name, string def = NullString) {
                return (string)Key().GetValue(name, def);
            }
            public static void SetString(string name, string val) {
                Key().SetValue(name, val);
            }

            public static bool GetBool(string name, bool def = false) {
                return (bool)Boolean.Parse(GetString(name, def.ToString()));
            }
            public static void SetBool(string name, bool val) {
                SetString(name, val.ToString());
            }

            public static Point? GetPoint(string name) {
                Point val = new Point(GetInt(name + "_X"), GetInt(name + "_Y"));
                if (val.X == NullInt || val.Y == NullInt) { return null; }
                return val;
            }
            public static void SetPoint(string name, Point? val) {
                SetInt(name + "_X", val == null ? NullInt : val.Value.X);
                SetInt(name + "_Y", val == null ? NullInt : val.Value.Y);
            }
        }

        public static int ActiveUser {
            get { return Reg.GetInt("ActiveUser"); }
            set { Reg.SetValue("ActiveUser", value); }
        }
        public static bool Maximized {
            get { return Reg.GetBool("Maximized", false); }
            set { Reg.SetValue("Maximized", value); }
        }

        #endregion
    }
}
