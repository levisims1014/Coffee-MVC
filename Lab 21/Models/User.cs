using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab_21.Models
{
    public class User
    {
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public string Email { set; get; }
        public string Phone { set; get; }
        public DateTime Birthday { get; set; }
        public string Password { set; get; }

        public User(string firstname, string lastname, string email, string phone, string password, DateTime birthday)
        {
            FirstName = firstname;
            LastName = lastname;
            Email = email;
            Phone = phone;
            Password = password;
            Birthday = birthday;
        }
    }
}