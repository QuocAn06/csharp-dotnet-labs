using EmployeeSystem;

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
                case "4":
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
        emp.ID = int.Parse(Console.ReadLine());

        Console.Write("_ Enter Name: ");
        emp.Name = Console.ReadLine();

        Console.Write("_ Enter Salary: ");
        emp.Salary = double.Parse(Console.ReadLine());

        employees.Add(emp);
        Console.WriteLine("Employee added successfully!");
    }



}