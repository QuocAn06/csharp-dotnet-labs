using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementLab
{
    public class Student
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public double GPA { get; set; }

        public Student() { }

        public Student(string studentID, string studentName, int studentAge, double studentGPA) 
        {
            ID = studentID;
            Name = studentName;
            Age = studentAge;
            GPA = studentGPA;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"ID: {ID}, Name: {Name}, Age: {Age}, GPA: {GPA}");
        }

    }
}
