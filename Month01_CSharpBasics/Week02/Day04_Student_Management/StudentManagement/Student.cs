using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementProject
{
    public class Student
    {
        //Properties
        public string ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public double GPA { get; set; }

        //Default constructor
        public Student() { }

        //Parameterized constructor
        public Student(string id, string name, int age, double gpa) 
        { 
            ID = id;
            Name = name;
            Age = age;
            GPA = gpa;
        }

        //Method to display student info
        public void DisplayInfo()
        {
            Console.WriteLine($"ID: {ID}, Name: {Name}, Age: {Age}, GPA: {GPA}");
        }
    }
}
