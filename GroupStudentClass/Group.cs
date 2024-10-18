using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupStudentClass
{
    internal class Group
    {
        public string group { get; }
        public string shift { get; }
        public Student[] students;
        public int studentCount = 0;
        public int maxStudent = 18;

        public Group(string group, string shift, int v)
        {
            this.group = group;
            this.shift = shift;
            students = new Student[maxStudent];
        }

        public Group(string group, string shift) {
            
        }

        public void AddStudent(Student student)
        {
            if (studentCount < maxStudent)
            {
                students[studentCount] = student;
                studentCount++;
                Console.WriteLine($"{student.Name} {student.Surname} qrupa elave edildi");
            }
            else
            {
                Console.WriteLine("Yerler dolub");
            }

        }


        public Student FindStudent(string name)
        {
           foreach (Student student in students)
            {
                if (student.Name == name && student != null)
                {
                    return student;
                }
            }
           return null;
        }
    }
}
