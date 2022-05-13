using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LocaLibrary.App.Models;

namespace LocaLibrary.App.Services
{
    internal class AuthService
    {
        public static UserLogin UserLogin { get; set; }

        public static void Login(UserLogin userLogin)
        {
            UserLogin = userLogin;
        }

        public static void Logout()
        {
            UserLogin = null;
        }
    }
}
