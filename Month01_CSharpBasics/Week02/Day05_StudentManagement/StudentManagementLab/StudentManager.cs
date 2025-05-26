using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementLab
{
    public class StudentManager
    {
        private List<Student> _students = new List<Student>();

        public void AddStudent()
        {
            Console.WriteLine("\nTHEM SINH VIEN MOI");

            //Nhap ho va ten
            Console.Write("_ Full Name: "); 
            string name = Console.ReadLine();

            string studentID;
            while (true) {
                Console.Write("_ Student ID: ");
                studentID = Console.ReadLine().Trim();

                if (_students.Any(s=>s.studentID.Equals(studentID, StringComparison.OrdinalIgnoreCase)))
                {
                    Console.WriteLine("Error: ID already exists!");
                    continue;
                }

                if (string.IsNullOrWhiteSpace(studentID))
                {
                    Console.WriteLine("Error: ID cannot be blank!");
                    continue;
                }

                break;
            }

            //Nhap diem voi kiem tra hop le
            double _score = 0;
            bool validScore = false;
            while (!validScore) {
                Console.Write("_ Score (0 - 10): ");
                string scoreInput = Console.ReadLine();

                if (double.TryParse(scoreInput, out _score) && _score >= 0 && _score <= 10)
                {
                    validScore = true;
                }
                else {
                    Console.WriteLine("Invalid score! Please enter a number from 0 to 10.");
                }
            }

            //Nhap khoa
            Console.Write("_ Faculty: ");
            string faculty = Console.ReadLine();

            // Tạo đối tượng sinh viên mới và thêm vào danh sách
            Student newStudent = new Student(studentID, name, _score, faculty);
            _students.Add(newStudent);

            Console.WriteLine("Thêm sinh viên thành công!");
        }

        public void DisplayAll()
        {   
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine($"| {"ID",-10} | {"Full Name",-20} | {"Score",-5} | {"Faculty",-15} |");
            Console.WriteLine("---------------------------------------------------------------");

            foreach (var student in _students)
            {
                Console.WriteLine(student.ToString());
            }

            Console.WriteLine("---------------------------------------------------------------");
        }

        public List<Student> FilterByFaculty(string faculty)
        {
            return _students.Where(s => s.studentFaculty.Equals(faculty)).ToList();
        }

        public List<Student> FilterByScore(double minScore)
        {
            return _students.Where(s=>s.studentScore >= minScore).ToList();
        }

        public Dictionary<string, int> CountByFaculty()
        {
            return _students.GroupBy(s => s.studentFaculty)
                            .ToDictionary(g => g.Key, g => g.Count());
        }

        public void DisplayCountByFaculty()
        {
            var facultyCounts = CountByFaculty(); // Gọi phương thức thống kê

            Console.WriteLine("\nTHỐNG KÊ SỐ LƯỢNG SINH VIÊN THEO KHOA");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("| {0,-20} | {1,-10} |", "Khoa", "Số lượng");
            Console.WriteLine("------------------------------------");

            foreach (var item in facultyCounts)
            {
                Console.WriteLine("| {0,-20} | {1,-10} |", item.Key, item.Value);
            }

            Console.WriteLine("------------------------------------");
            Console.WriteLine($"Tổng số sinh viên: {_students.Count}");
        }

        public double CalculateAverageScore()
        {
            return _students.Average(s => s.studentScore);
        }
    }
}
