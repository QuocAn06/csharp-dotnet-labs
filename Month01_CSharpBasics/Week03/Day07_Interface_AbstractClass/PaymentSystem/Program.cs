using PaymentSystem.Core.Processors;

namespace PaymentSystem
{
    class Program
    {
        static void Main()
        {
            var processor = new PaymentProcessor();
            //var payments = InitializePayments();

            while (true) {
                DisplayMenu();
            }
        }

        static void DisplayMenu()
        {
            Console.Clear();
            Console.WriteLine("=== PAYMENT SYSTEM ===");
            Console.WriteLine("1. Momo Payment");
            Console.WriteLine("2. ZaloPay Payment");
            Console.WriteLine("3. VNPAY Payment");
            Console.WriteLine("4. Cash Payment");
            Console.WriteLine("5. Bank Transfer");
            Console.WriteLine("0. Exit");
            Console.Write("Select (0 - 5): ");
        }


    }
}