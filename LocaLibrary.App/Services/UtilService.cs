using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Text.RegularExpressions;

namespace LocaLibrary.App.Services
{
    internal class UtilService
    {
        public static bool IsValidEmail(string email)
        {
            var EMAIL_REGEX = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|" + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)" + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";
            var regex = new Regex(EMAIL_REGEX, RegexOptions.IgnoreCase);
            return regex.IsMatch(email);
        }
    }
}
