using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GroupStudentClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Group group = new Group("qrup AB205", "gunorta", 3);

            Student firstStudent = new Student("Xanim", "Aliyeva", "female", 19, "0559993232", 4);
            Student secondStudent = new Student("Ferid", "Hasanov", "male", 20, "0701115656", 0);
            Student thirdStudent = new Student("Esma", "Hatamova", "female", 20, "0508882277", 3);
           
            Console.WriteLine("Qrupdaki telebeler");

            group.AddStudent(firstStudent);
            group.AddStudent(secondStudent);
            group.AddStudent(thirdStudent);


            foreach (Student student in group.students)
            {
                if ( student != null)
                {
                    Console.WriteLine($"{student.Name}, {student.Surname} , {student.Gender} , {student.Age}, {student.PhoneNumber}, {student.Limit}");
                }
            }

            firstStudent.Absent();
            Console.WriteLine($"Qalan limit {firstStudent.Limit}");

            secondStudent.Absent();
            Console.WriteLine($"Qalan limit {secondStudent.Limit}");

            thirdStudent.Absent();
            Console.WriteLine($"Qalan limit {thirdStudent.Limit}");
    


        }
    }
}
