using System;
using System.Xml.Linq;
using StudentManagementLab;

namespace StudentManagementLab
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentManager manager = new StudentManager();

            Console.WriteLine("STUDENT MANAGEMENT SYSTEM");
            Console.WriteLine("-------------------------");

            bool running = true;
            while (running)
            {
                Console.WriteLine("\nMenu: ");
                Console.WriteLine("1. Add new student");
                Console.WriteLine("2. Display all students");
                Console.WriteLine("3. Calculate average GPA");
                Console.WriteLine("0. Exit");

                Console.Write("Choose an option (0-3): ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        manager.AddStudent(); 
                        break;
                    case "2":
                        manager.ShowAllStudents();
                        break;
                    case "3":
                        Console.WriteLine("Average GPA: " + manager.CalculateAverageGPA());
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }
}