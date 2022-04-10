using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace _18ofMarch_FacebookHW.Models
{
    internal class User
    {
        public string Name;
        public string Surname;
        public string Email;
        public int DateofBirth;
        public bool isSingle;
        public Post[] Posts;

        Regex isValid = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
        public User(string Name, string Surname, string Email)
        { 
            this.Name = Name;
            this.Surname = Surname;
            if (isValid.IsMatch(Email)) this.Email = Email;
        }
        public User(string Name, string Surname, string Email, int DateofBirth) : this(Name, Surname, Email)
        {
            this.DateofBirth = DateofBirth;
        }
        public User(string Name, string Surname, string Email, int DateofBirth, bool isSingle) : this( Name, Surname, Email, DateofBirth)
        {
            this.isSingle = isSingle;
        }
    }
}
