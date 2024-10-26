using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionTask.Models
{
    internal class User
    {
        private int id;
        private string name;
        private string surname;
        private static int age;

        public User(int id, string name, string surname)
        {
            this.id = id;
            this.name = name;
            this.surname = surname;
        }

        public void GetFullName()
        {
            Console.WriteLine($"{name} {surname}");
        }

        public static void ChangeAge(int modifiedAge)
        {
            age = modifiedAge;
        }
        public static int GetAge()
        {
            return age;
        }

        public override string ToString()
        {
            return $"{id}, {name}, {surname}, {age}"; 
        }

      
    }
}
