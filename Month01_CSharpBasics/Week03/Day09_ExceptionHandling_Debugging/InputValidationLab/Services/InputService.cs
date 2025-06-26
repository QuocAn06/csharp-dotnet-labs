using InputValidationLab.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Diagnostics;

namespace InputValidationLab.Services
{
    public class InputService
    {
        // 1. Get the user's name
        public string GetName()
        {
            while (true)
            {
                try
                {
                    Console.Write("Enter your username: ");
                    var inputValue = Console.ReadLine()?.Trim();

                    if (!string.IsNullOrWhiteSpace(inputValue))
                    {
                        return inputValue;
                    }

                    Console.WriteLine("This field is required. Please enter a value.");

                }
                catch (Exception ex)
                {
                    Console.WriteLine($"[ERROR] GetName: {ex.Message}");
                }
            }
        }

        // 2. Get the user's age
        public int GetAge()
        {
            while (true)
            {
                try
                {
                    Console.Write("Enter your age: ");
                    var inputValue = Console.ReadLine();

                    if (int.TryParse(inputValue, out int age) && age > 0)
                    {
                        return age;
                    }

                    Console.WriteLine("Invalid input. Whole numbers only, please.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"[ERROR] GetAge: {ex.Message}");
                }
            }
        }


        // 3. Get the user's email
        public string GetEmail()
        {
            while (true)
            {
                try
                {
                    Console.Write("Enter your email: ");
                    var inputValue = Console.ReadLine()?.Trim();

                    if (Regex.IsMatch(inputValue, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                    {
                        return inputValue;
                    }

                    Console.WriteLine("Invalid email format.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"[ERROR] GetEmail: {ex.Message}");
                }
            }
        }

        // 4. Get the user's infomation
        public User GetUserInfo()
        {   
            try
            {
                var userInfo = new User
                {
                    Name = GetName(),
                    Age = GetAge(),
                    Email = GetEmail()
                };

                return userInfo;

            }
            catch (Exception ex)
            {
                Console.WriteLine($"[FATAL] GetUserInfo: {ex.Message}");
                return null;
            }
        }

    }
}
