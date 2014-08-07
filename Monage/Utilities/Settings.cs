using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;
using System.Drawing;

namespace Monage {
    public static class Settings {
        #region Constants

        public const int NameLen = 45;

        #endregion

        #region RegistryValues

        public static int ActiveUser {
            get { return Reg.GetInt("ActiveUser"); }
            set { Reg.SetInt("ActiveUser", value); }
        }

        public static int SplitterDistance {
            get { return Reg.GetInt("SplitterDistance", 1534); }
            set { Reg.SetInt("SplitterDistance", value); }
        }

        public static int FilterBanks {
            get { return Reg.GetInt("FilterBanks", 0); }
            set { Reg.SetInt("FilterBanks", value); }
        }

        public static int FilterBuckets {
            get { return Reg.GetInt("FilterBuckets", 0); }
            set { Reg.SetInt("FilterBuckets", value); }
        }

        public static bool FilterConfirmed {
            get { return Reg.GetBool("FilterConfirmed", false); }
            set { Reg.SetBool("FilterConfirmed", value); }
        }

        public static bool Maximized {
            get { return Reg.GetBool("Maximized", false); }
            set { Reg.SetBool("Maximized", value); }
        }

        // null/default values to compare against
        public const int NullInt = -int.MaxValue;

        private static class Reg {
            public static RegistryKey Key() {
                return
                    Registry.CurrentUser
                        .CreateSubKey("Software")
                            .CreateSubKey("Monage");
            }

            // Expose RegistryKey Methods
            public static object GetValue(string name, object def) { return Key().GetValue(name, def); }
            public static void SetValue(string name, object val) { Key().SetValue(name, val); }

            // Custom handling of different data-types for convenience
            public static int GetInt(string name, int def = NullInt) { return (int)Key().GetValue(name, def); }
            public static void SetInt(string name, int val) { Key().SetValue(name, val); }

            public static string GetString(string name, string def = "") { return (string)Key().GetValue(name, def); }
            public static void SetString(string name, string val) { Key().SetValue(name, val); }

            public static bool GetBool(string name, bool def = false) { return Boolean.Parse(GetString(name, def.ToString())); }
            public static void SetBool(string name, bool val) { SetString(name, val.ToString()); }

            public static Point GetPoint(string name) { return new Point(GetInt(name + "_X", 0), GetInt(name + "_Y", 0)); }
            public static void SetPoint(string name, Point val) { SetInt(name + "_X", val.X); SetInt(name + "_Y", val.Y); }
        }

        #endregion
    }
}
