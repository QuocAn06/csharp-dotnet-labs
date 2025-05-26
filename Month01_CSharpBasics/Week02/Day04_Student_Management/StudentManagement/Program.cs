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
                Console.WriteLine("4. Exit");
                Console.WriteLine("5. Save to file");
                Console.Write("Choose an option (1-4): ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddNewStudent(manager); 
                        break;
                    case "2":
                        manager.DisplayAllStudents(); 
                        break;
                    case "3":
                        double avgGPA = manager.CalulateAverageGPA();
                        Console.WriteLine($"\nAverage GPA of all students: {avgGPA:F2}");
                        break;
                    case "4":
                        Console.Write("Enter file path (default: students.json): ");
                        string filePath = Console.ReadLine();
                        filePath = string.IsNullOrWhiteSpace(filePath) ? "students.json" : filePath;

                        if (File.Exists(filePath))
                        {
                            Console.Write("File already exists. Overwrite? (y/n): ");
                            if (Console.ReadLine().ToLower() != "y")
                                break;
                        }

                        manager.SaveToFile(filePath);
                        break;
                    case "5":
                        running = false;
                        Console.WriteLine("Exiting program...");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        static void AddNewStudent(StudentManager manager)
        {
            Console.WriteLine("\nEnter new student information:");

            Console.Write("ID: ");
            string studentID = Console.ReadLine();

            Console.Write("Name: ");
            string studentName = Console.ReadLine();

            Console.Write("Age: ");
            int studentAge;
            while(!int.TryParse(Console.ReadLine(), out studentAge) || studentAge <= 0)
            {
                Console.Write("Invalid age. Please enter a positive number: ");
            }

            Console.Write("GPA (0.0 - 4.0): ");
            double studentGPA;
            while(!double.TryParse(Console.ReadLine(),out studentGPA) || studentGPA < 0 || studentGPA > 4)
            {
                Console.Write("Invalid GPA. Please enter a value between 0.0 and 4.0: ");
            }

            Student newStudent = new Student(studentID, studentName, studentAge, studentGPA);
            manager.AddStudent(newStudent);
        }
    }
}