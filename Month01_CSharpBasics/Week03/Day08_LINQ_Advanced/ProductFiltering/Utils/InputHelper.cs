using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductFiltering.Utils
{
    public static class InputHelper
    {
        public static string ReadString(string prompt)
        {
            string? inputValue;
            do
            {
                Console.Write(prompt);
                inputValue = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(inputValue))
                {
                    Console.WriteLine("This field is required. Please enter a value.");
                }

            } while (string.IsNullOrWhiteSpace(inputValue));
            
            return inputValue;
        }

        public static int ReadInt(string prompt)
        {
            int inputValue;
            while (true)
            {
                Console.Write(prompt);
                if (int.TryParse(Console.ReadLine(), out inputValue))
                {
                    return inputValue;
                }

                Console.WriteLine("Invalid input. Whole numbers only, please.");
            }
        }

        public static decimal ReadDecimal(string prompt)
        {
            decimal inputValue;
            while (true)
            {
                Console.Write(prompt);
                if (decimal.TryParse(Console.ReadLine(), out inputValue))
                {
                    return inputValue;
                }

                Console.WriteLine("Invalid input. Whole numbers only, please.");
            }
        }
    }
}
