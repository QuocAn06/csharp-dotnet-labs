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
        private List<Student> students;

        //Constructor
        public StudentManager() 
        {
            students = new List<Student>(); //Khởi tạo danh sách
            LoadFromFile(); //Tự động load dữ liệu
        }

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

        public void SaveToFile(string filePath)
        {
            string json = JsonConvert.SerializeObject(students, Formatting.Indented);
            File.WriteAllText(filePath, json);
        }

        public void LoadFromFile(string filePath = "students.json")
        {
            try
            {
                if (File.Exists(filePath))
                {
                    string json = File.ReadAllText(filePath);
                    students = JsonConvert.DeserializeObject<List<Student>>(json);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading file: {ex.Message}");
            }
        }
    }
}
