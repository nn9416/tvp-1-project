using System.Collections.Generic;
using tvp_1_project.Model;

namespace tvp_1_project.BussinesLogic
{
    public static class Authentication
    {
        public static bool Authenticate(string username, string password, List<User> users)
        {
            if (CheckUsername(username, password, users))
            {
                IsAdmin = username.Equals("admin");
                CurrentUser = username;
                return true;
            }            
            return false;
        }

        public static bool CheckUsername(string username, string password, List<User> users)
        {
            foreach (User user in users)
            {
                if (user.Username.Equals(username))
                    return CheckPassword(password, user);
            }
            // TODO: Notify user that username is non existent
            return false;
        }

        public static bool CheckPassword(string password, User user)
        {
            if (user.Password.Equals(password))            
                return true;
            
            // TODO: Notify user that password is wrong
            return false;
        }

        public static bool IsAdmin { get; private set; }
        public static string CurrentUser { get; private set; }
    }
}
