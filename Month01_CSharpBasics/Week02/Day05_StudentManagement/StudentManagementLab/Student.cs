using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementLab
{
    public class Student
    {
        // Properties (auto-implemented hoặc với backing field)
        public string studentID { get; set; }
        public string studentName { get; set; }
        public double studentScore { get; set; }
        public string studentFaculty { get; set; } // Khoa

        //Constructor
        public Student(string id, string name, double score, string faculty)
        {
            studentID = id;
            studentName = name;
            studentScore = score;
            studentFaculty = faculty;
        }

        // Method hiển thị thông tin
        public override string ToString() {
            return $"| {studentID, -10} | {studentName, -20} | {studentScore, -5} | {studentFaculty, -15} |";
        }
    }
}
