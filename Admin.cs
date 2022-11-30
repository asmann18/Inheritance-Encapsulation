using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelebeYaziqdiElemeyin
{
    internal class Admin:User
    {
        public bool isSuperAdmin;
        public string section;

        public Admin(string username,string password, bool isSuperAdmin, string section):base(username,password)
        {
            this.isSuperAdmin = isSuperAdmin;
            this.section = section;
        }

        #region signInEmeliyyatlari
        public string signInUsername()
        {
            Console.Write("Username:");
            string username = Console.ReadLine();
            return username;
        }
        public string enterPassword()
        {
            Console.Write("Password:");
            string password = Console.ReadLine();
            return password;
        }
        public void viewInfo()
        {
            Console.WriteLine(isSuperAdmin+" "+section);
        }
        #endregion
        public void signIn()
        {
        enterAgainUsername:
            if (signInUsername() == userName)
            {
            enterAgainPassword:
                if (enterPassword() == password)
                {
                    viewInfo();
                }
                else
                {
                    Console.WriteLine("You entered the wrong password,enter again");
                    goto enterAgainPassword;
                }
            }
            else
            {
                Console.WriteLine("No such username,enter again");
                goto enterAgainUsername;
            }
        }
    }

}
