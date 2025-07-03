using InputValidationLab.Models;
using InputValidationLab.Services;

namespace InputValidationLab
{
    class Program
    {
        static void Main()
        {
            var inputService = new InputService();

            Console.WriteLine("=== USER REGISTRATION SYSTEM ===\n");

            User userInfo = inputService.GetUserInfo();

            Console.WriteLine("\nENTERED INFORMATION:");
            Console.WriteLine($"Name: {userInfo.Name}");
            Console.WriteLine($"Age: {userInfo.Age}");
            Console.WriteLine($"Email: {userInfo.Email}");
        }
    }
}