using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ContactManagerLab.Utils
{
    public class InputHelper
    {
        // 1. Get the user's name
        public static string GetName()
        {
            while (true)
            {
                try
                {
                    Console.Write("Enter name: ");
                    var input = Console.ReadLine()?.Trim();

                    if (string.IsNullOrWhiteSpace(input))
                        throw new ArgumentException("Name is required.");

                    if (input.Length > 8)
                        throw new ArgumentException("Name must be at least 8 characters.");

                    return input;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"[ERROR] Name: {ex.Message}");
                }
            }
        }

        // 2. Get the user's phone number
        public static string GetPhoneNumber()
        {
            while (true)
            {
                try
                {
                    Console.Write("Enter phone number: ");
                    var input = Console.ReadLine()?.Trim();

                    if (string.IsNullOrWhiteSpace(input))
                        throw new ArgumentException("Phone number is required.");

                    if (!Regex.IsMatch(input, @"^\d{9,11}$"))
                        throw new ArgumentException("Phone number must be 9 to 11 digits.");

                    return input;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"[ERROR] Phone number: {ex.Message}");
                }
            }
        }

        // 3. Get the user's email
        public static string GetEmail()
        {
            while (true)
            {
                try
                {
                    Console.Write("Enter email: ");
                    var input = Console.ReadLine()?.Trim();

                    if (string.IsNullOrWhiteSpace(input))
                        throw new ArgumentException("Email is required.");

                    if (!Regex.IsMatch(input, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                        throw new ArgumentException("Invalid email format.");

                    return input;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"[ERROR] Email: {ex.Message}");
                }
            }
        }


    }
}
