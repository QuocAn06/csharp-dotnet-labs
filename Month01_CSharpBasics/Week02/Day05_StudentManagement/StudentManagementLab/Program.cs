using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentManager manager = new StudentManager();
            bool running = true;

            while (running) {
                Console.WriteLine("\nSTUDENT MANAGEMENT");
                Console.WriteLine("==============================");
                Console.WriteLine("1. Add new student");
                Console.WriteLine("2. Display all students");
                Console.WriteLine("3. Filter by faculty");
                Console.WriteLine("4. Filter by score");
                Console.WriteLine("6. Count by faculty");
                Console.WriteLine("7. Calculate average score");
                Console.WriteLine("0. Exit");
                Console.Write("=> Select content (0 - 6): ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        // Nhập thông tin và gọi manager.AddStudent()
                        manager.AddStudent();
                        break;  
                    case 2:
                        manager.DisplayAll();
                        break;
                    case 3:
                        // Nhập khoa và hiển thị kết quả FilterByFaculty()
                        Console.Write("_ Enter Faculty Information: ");
                        string _faculty = Console.ReadLine();
                        manager.FilterByFaculty(_faculty);
                        break;
                    case 4:
                        // Nhập điểm và hiển thị kết quả FilterByGrade() 
                        double _score = 0;
                        bool validScore = false;
                        while (!validScore)
                        {
                            Console.Write("_ Enter score: ");
                            string scoreInput = Console.ReadLine();

                            if (double.TryParse(scoreInput, out _score) && _score >= 0 && _score <= 10)
                            {
                                validScore = true;
                            }
                            else
                            {
                                Console.WriteLine("Invalid score! Please enter a number from 0 to 10.");
                            }
                        }
                        manager.FilterByScore(_score);
                        break;
                    case 5:
                        // Hiển thị kết quả CountByFaculty()
                        manager.DisplayCountByFaculty();
                        break;
                    case 6:
                        Console.WriteLine($"Điểm TB: {manager.CalculateAverageScore()}");
                        break;
                    case 0:
                        running = false;
                        break;
                }
            }
        }
    }
}
