using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupStudentClass
{
    internal class Student
    {
    
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public string PhoneNumber { get; set; }
        public string Group { get; set; }
        private int limit;
        public int Limit {
            get { return limit; }
            set
            {
                if (value < 0)
                {
                    limit = 0;
                }
                else
                {
                    limit = value;
                }
            }
        }
   
        public Student(string name, string surname , string gender, int age, string phoneNumber, int limit)
        {
            Name = name;
            Surname = surname;
            Gender = gender;
            Age = age;
            PhoneNumber = phoneNumber;
            Limit = limit;
          
        }

        public void Absent()
        {
            if (Limit > 0)
            {
                Limit--;
                Console.WriteLine($"{Name} bu gun dersde istirak etmeyib");
            }
            else if (Limit == 0) 
            {
                Console.WriteLine($"{Name} kesilib");
            }

        }
    }
}
