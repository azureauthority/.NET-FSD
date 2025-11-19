using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public static class AuthService
    {         
        private const string ValidUser = "admin";
        private const string ValidPass = "admin123";

        public static bool Login(string uid, string pwd)
        {
            if (string.IsNullOrWhiteSpace(uid) || string.IsNullOrWhiteSpace(pwd))
                return false;

            bool isValid = (uid == ValidUser && pwd == ValidPass);

            return isValid;
        }
    }
}
