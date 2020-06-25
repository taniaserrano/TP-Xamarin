using System;
using System.Collections.Generic;
using System.Text;

namespace AppTweet.Models
{
   public class User
    {

        public int UserId { get; set; }
        public String Pseudo { get; set; }
        public String Login { get; set; }
        public String Password { get; set; }

        public User() { }
       
        public User(string login, string password)
        {
            Login = login;
            Password = password;
        }
    }
}
}
