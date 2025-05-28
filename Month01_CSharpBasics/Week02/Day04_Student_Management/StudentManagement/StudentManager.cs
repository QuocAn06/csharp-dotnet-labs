using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace StudentManagementLab
{
    public class StudentManager
    {
        private List<Student> studentList = new List<Student>();

        public void AddStudent()
        {
            Console.WriteLine("\nADD NEW STUDENT");

            Console.Write("_ Enter Student ID: ");
            string studentID = Console.ReadLine();

            Console.Write("_ Enter Full Name: ");
            string studentName = Console.ReadLine();

            int age;
            while (true) 
            {
                Console.Write("_ Enter Age (>=0): ");
                if (int.TryParse(Console.ReadLine(), out age) && age >=0)
                    break;
                Console.WriteLine("Invalid Age. Please enter a non-negative number.");
            }

            double gpa;
            while (true) 
            {
                Console.Write("_ Enter GPA (0.0 - 4.0): ");
                if(double.TryParse(Console.ReadLine(), out gpa) && gpa >=0 && gpa <= 4)
                    break;
                Console.WriteLine("Invalid GPA. Please enter a number between 0.0 and 4.0.");
            }

            Student newStudent = new Student 
            {
                ID = studentID,
                Name = studentName,
                Age = age,
                GPA = gpa
            };

            studentList.Add(newStudent);

            Console.WriteLine("Student added successfully.\n");

        }

        public void ShowAllStudents()
        {
            foreach (var studentInfo in studentList)
            {
                studentInfo.DisplayInfo();
            }
        }

        public double CalculateAverageGPA()
        {
            return studentList.Average(s => s.GPA);
        }
    }
}
