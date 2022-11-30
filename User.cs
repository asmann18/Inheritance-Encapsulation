using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelebeYaziqdiElemeyin
{
    internal class User
    {
        private string _username;
        private string _password;

        public User(string username, string password)
        {
            this._username = username;
            _password = password;
        }
        public string userName
        {
            get
            {
                return _username;
            }
            set
            { 
                if (value.Length > 6)
                {
                    _username=value;
                }
                else
                {
                    Console.WriteLine("Please enter valid username");
                }
            }
        }
        public string password
        {
            get
            {
                return _password;
            }
            set {
                Regex regex = new Regex(@"\d+[A-Z]+");
                Match match = regex.Match(value);
                if(match.Success==true)
                {
                    _password=value;
                }
                else
                {
                    Console.WriteLine("Please enter valid password");
                }
            }
        }
    }
}
