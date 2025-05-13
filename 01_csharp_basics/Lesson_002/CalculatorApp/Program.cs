// May Tinh Co Ban
//1. Nhap 2 so tu ban phim
//2. Chon phep tinh tu ban phim
//3. Tinh toan va in ra ket qua

using System;

namespace CalculateApp
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2;

            Console.WriteLine("=== Chuong Trinh May Tinh Co Ban ===");

            while (true)
            {
                //Hien thi menu
                DisplayMenu();

                //Nhap lua chon tu nguoi dung
                string choice = Console.ReadLine();

                if (choice == "5")
                {
                    break;
                }

                //Nhap 2 so tu ban phim
                num1 = GetNumber("Nhap so thu nhat: ");
                num2 = GetNumber("Nhap so thu hai: ");

                //Thuc hien phep tinh
                PerformCalculation(choice, num1, num2);

            }

            Console.WriteLine("Cam on da su dung chuong trinh!");
        }

        static double GetNumber(string prompt)
        {
            double numberInput;
            Console.Write(prompt);

            while (!double.TryParse(Console.ReadLine(),out numberInput)) 
            {
                Console.WriteLine("Sai dinh dang! Vui long nhap lai: ");
                Console.Write(prompt); // Hiển thị lại prompt
            }
           
            return numberInput;
        }

        static void DisplayMenu()
        {
            Console.WriteLine("\nChon phep tinh: ");
            Console.WriteLine("1. Cong (+)");
            Console.WriteLine("2. Tru (-)");
            Console.WriteLine("3. Nhan (*)");
            Console.WriteLine("4. Chia (/)");
            Console.WriteLine("5. Thoat (Exit)");
            Console.Write("Nhap lua chon (1-5): ");
        }

        static void PerformCalculation(string choice, double num1, double num2) 
        {
            double result = 0;
            string operation = "";

            switch (choice)
            {
                case "1":
                    result = Add(num1, num2);
                    operation = "+";
                    break;
                case "2":
                    result = Subtract(num1, num2);
                    operation = "-";
                    break;
                case "3":
                    result = Multiply(num1, num2);
                    operation = "*";
                    break;
                case "4":
                    if (num2 == 0)
                    {
                        Console.WriteLine("Loi: Khong the chia cho 0!");
                        return;
                    }
                    result = Divide(num1, num2);
                    operation = "/";
                    break;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ!");
                    return;
            }

            Console.WriteLine($"Ket qua: {num1} {operation} {num2} = {result}");
        }

        //Cac ham tinh toan rieng biet
        static double Add(double fristNumber, double secondNumber) => fristNumber + secondNumber;
        static double Subtract(double fristNumber, double secondNumber) => fristNumber - secondNumber;
        static double Multiply(double fristNumber, double secondNumber) => fristNumber * secondNumber;
        static double Divide(double fristNumber, double secondNumber) => fristNumber / secondNumber;

    }
}