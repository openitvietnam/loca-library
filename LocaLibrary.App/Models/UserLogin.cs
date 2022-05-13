using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocaLibrary.App.Models
{
    internal class UserLogin
    {
        public int Id { get; }
        public string Email { get; }
        public string FullName { get; }
        public bool IsAdmin { get; }

        public UserLogin(int id, string email, string fullName, bool isAdmin)
        {
            Id = id;
            Email = email;
            FullName = fullName;
            IsAdmin = isAdmin;
        }
    }
}
