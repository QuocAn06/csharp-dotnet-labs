using System;
using MultiPaymentSystem.Payments;
using MultiPaymentSystem.Helpers;


namespace MultiPaymentSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhập số tiền: ");
            double amount = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Chọn phương thức thanh toán:");
            Console.WriteLine("1. Momo\n2. ZaloPay\n3. Cash\n4. Bank Transfer");

            int choice = Convert.ToInt32(Console.ReadLine());

            Payment payment = PaymentFactory.GetPaymentMethod(choice);

            if (payment == null)
            {
                Console.WriteLine("Lựa chọn không hợp lệ.");
                return;
            }

            payment.Pay(amount);
        }
    }
}