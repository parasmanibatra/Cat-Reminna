using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AppReminaInterfaces;

namespace AppRemina
{
    public class AppReminaService : IAuthenticationService
    {
        public bool Ping()
        {
            return true;
        }
        public bool Authenticate(string userName, string password)
        {
             bool isAuthenticate = false;
             if (userName.ToLower() == "cat" && password.ToLower() == "remina")
             {
                 isAuthenticate = true;
             }
             return isAuthenticate;
        }
        public List<string> GetUsers()
        {
            List<string> users = new List<string>();
            users.Add("Devum Srivastava");
            users.Add("Parasmani Batra");
            return users;
        }
    }
}
