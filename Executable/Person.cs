using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace Executable
{
    public class Person
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public byte Age { get; set; }
        public DateTime Birthday { get; set; }

        public Person (string username, string password, string name, string surname, byte age, DateTime birthday)
        {
            UserName = username;
            Password = password;
            Name = name;
            Surname = surname;
            Age = age;
            Birthday = birthday;
        }
        public Person()
        {
            
        }

    }
}
