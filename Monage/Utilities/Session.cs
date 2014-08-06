using Monage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monage {
    public class Session {
        public static Context db { get; private set; }
        public static User User { get; private set; }
        private static int UserID {
            get { return Settings.ActiveUser; }
            set { Settings.ActiveUser = value; }
        }

        public static Context Start() {
            Session.db = new Context();

            // There are three states: no setting, logged out, and logged in
            if (Session.UserID == Settings.NullInt) {
                // In the case of no setting log in if there's only one user
                if (Session.db.Users.Count() == 1) {
                    Session.User = db.Users.First();
                    Session.UserID = Session.User.ID;
                } else {
                    Session.User = null;
                }
            } else {
                // This handles the case of being logged out and logged in
                // An invalid ID is also treated as logged out
                Session.User = db.Users.FirstOrDefault(x => x.ID == Session.UserID);
                if (Session.User == null) { Session.UserID = 0; }
            }

            return Session.db;
        }
        public static Context Refresh() {
            Session.db = new Context();
            Session.User = db.Users.FirstOrDefault(x => x.ID == Session.UserID);
            return Session.db;
        }

        public static User Login(int UserID) {
            Session.User = db.Users.First(x => x.ID == UserID);
            Session.UserID = User.ID;
            return Session.User;
        }
        public static User Login(string Username) {
            Session.User = db.Users.First(x => x.Username == Username);
            Session.UserID = User.ID;
            return Session.User;
        }
        public static User Logout() {
            Session.User = null;
            Session.UserID = 0;
            return null;
        }
    }
}
