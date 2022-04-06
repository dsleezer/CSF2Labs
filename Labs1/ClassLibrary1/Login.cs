﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Login
    {
        private string _userName;
        private string _password;

        public string UserName { get { return _userName; } set { _userName = value; } }
        public string Password { get { return _password; } set { _password = value; } }

        public Login(string userName, string password)
        {
            UserName = userName;
            Password = password;
        }
        public Login() { }

        public override string ToString()
        {
            return string.Format($"Username: {UserName}\nPassword: {Password}\n");
        }
    }
}
