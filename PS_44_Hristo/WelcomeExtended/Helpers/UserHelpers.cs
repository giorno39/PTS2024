﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Welcome.Model;
using WelcomeExtended.Data;

namespace WelcomeExtended.Helpers
{
    internal static class UserHelpers
    {
        static public string? ToString(this User user, bool isEx) {
            return $"{user.Id} - {user.Names} - {user.Role}";
        }

        public static void ValidateCredentials(this UserData userData, string name, string password)
        {
            if (name.Length < 1)
            {
                throw new Exception("Name cannot be empty!");
            }
            else if (password.Length < 1)
            {
                throw new Exception("Password cannot be empty!");
            }
            userData.ValidateUser(name, password);
        }

        public static User? GetUser(this UserData userData, string name, string password)
        {
            return userData.GetUser(name, password);
        }
    }

}

