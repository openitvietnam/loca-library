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
        public bool IsAdmin { get; }

        public UserLogin(int id, bool isAdmin)
        {
            Id = id;
            IsAdmin = isAdmin;
        }
    }
}
