using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login_System
{
   public class Users
    {
        

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }
        public DateTime DateOfBearth { get; set; }

        public Users(string firstName, string lastName, string userName, string password, DateTime dateTime)
        {
            FirstName = firstName;
            LastName = lastName;
            UserName = userName;
            Password = password;
            DateOfBearth = dateTime;
        }
        
    }
}
