using EmployeeSystem;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Diagnostics.Metrics;

class Program
{
    static List<Employee> employees = new List<Employee>();

    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.Title = "Employee System by Department";

        while (true)
        {
            Console.WriteLine("\n=== MENU ===");
            Console.WriteLine("1. Add new Employee");
            Console.WriteLine("2. Display all employees' tasks");
            Console.WriteLine("3. Salary statistics by department");
            Console.WriteLine("0. Exit");
            Console.Write("Enter your choice (0 - 3): ");

            switch (Console.ReadLine())
            {
                case "1":
                    AddEmployee();
                    break;
                case "2":
                    ShowAllWork();
                    break;
                case "3":
                    CalculateDepartmentSalaries();
                    break;
                case "0":
                    return;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ!");
                    break;
            }
        }

    }

    static void AddEmployee()
    {
        Console.WriteLine("\nSelect department:");
        Console.WriteLine("1. Developer");
        Console.WriteLine("2. Tester");
        Console.WriteLine("3. HR");
        Console.WriteLine("4. Manager");
        Console.Write("Enter your choice (1-4): ");
        string type = Console.ReadLine();

        Employee emp = null;
        switch (type) { 
            case "1":
                emp = new Developer { Department = "Developer" };
                break;
            case "2":
                emp = new Tester { Department = "Tester" };
                break;
            case "3":
                emp = new HR { Department = "HR" };
                break;
            case "4":
                emp = new Manager { Department = "Manager" };
                break;
            default:
                Console.WriteLine("Invalid choice!");
                return;
        }

        Console.Write("_ Enter ID: ");
        emp.ID = Console.ReadLine();

        Console.Write("_ Enter Name: ");
        emp.Name = Console.ReadLine();

        double empSalary = 0;
        while (true) 
        {
            Console.Write("_ Enter Salary (>0): ");
            if (double.TryParse(Console.ReadLine(), out empSalary) && empSalary > 0)
                break;
            Console.WriteLine("Invalid Salary. Please enter a non - negative number.");
        }
        emp.Salary = empSalary;


        Console.Write("_ Enter Department: ");
        emp.Department = Console.ReadLine();

        employees.Add(emp);
        Console.WriteLine("Employee added successfully!");
    }

    static void ShowAllWork()
    {
        Console.WriteLine("\n=== DANH SACH CONG VIEC ===");
        foreach (var emp in employees)
        {
            emp.Work();
        }
    }

    static void CalculateDepartmentSalaries()
    {
        Console.WriteLine("\n=== THONG KE LUONG ===");

        var result = employees.GroupBy(e => e.Department)
                              .Select(g => new {
                                  Department = g.Key,
                                  TotalSalary = g.Sum(e => e.Salary),
                                  Count = g.Count()
                              });

        foreach (var item in result)
        {
            Console.WriteLine($"{item.Department}: {item.Count} employees, Total salary: {item.TotalSalary:N0} VND");
        }
    }

}