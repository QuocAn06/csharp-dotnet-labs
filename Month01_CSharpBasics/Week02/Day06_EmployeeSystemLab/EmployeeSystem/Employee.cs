using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSystem
{
    // Lớp cha trừu tượng
    public abstract class Employee
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public string Department { get; set; } // Thêm phòng ban

        public abstract void Work();
    }

    //  Các lớp con override phương thức Work()
    public class Developer: Employee
    {
        public override void Work() => Console.WriteLine($"{Name} (Developer): Writing code...");
    }

    public class Tester: Employee
    {
        public override void Work() => Console.WriteLine($"{Name} (Tester): Testing software...");
    }

    public class HR: Employee
    {
        public override void Work() => Console.WriteLine($"{Name} (HR): Recruiting personnel...");
    }

    public class Manager : Employee
    {
        public override void Work() => Console.WriteLine($"{Name} (Manager): Managing project...");
    }


}
