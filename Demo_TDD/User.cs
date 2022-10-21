using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Demo_TDD
{
    public class User
    {
        public bool CheckPassword(string password)
        {
           
            if (string.IsNullOrEmpty(password) || password.Length < 8 
                || password.Contains(" ") || !NotContainSpecialChar(password))
            {
                return false;
            }
            return true;
        }

        private bool NotContainSpecialChar(string password)
        {
            Regex reg = new Regex("^[a-zA-Z0-9]*$");
            Match match = reg.Match(password);
            if (match.Success)
            {
                return true;
            }
            return false;
        }
    }
}
