using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementProject
{
    public class StudentManager
    {
        private List<Student> students = new List<Student>();

        //Add new student
        public void AddStudent(Student student)
        {
            students.Add(student);
            Console.WriteLine("Student added successfully!");
        }

        //Display all students
        public void DisplayAllStudents()
        {
            Console.WriteLine("\nList of Student: ");
            foreach (var student in students)
            {
                student.DisplayInfo();
            }
        }

        //Calculate average GPA
        public double CalulateAverageGPA()
        {
            if (students.Count == 0)
                return 0;

            double totalGPA = 0;
            foreach (var student in students)
            {
                totalGPA += student.GPA;
            }
            return totalGPA / students.Count;
        }
    }
}
