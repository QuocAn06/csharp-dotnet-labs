using MultiPaymentSystem.Payments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiPaymentSystem.Helpers
{
    public static class PaymentFactory
    {
        public static Payment GetPaymentMethod(int choice)
        {
            return choice switch
            {
                1 => new MomoPayment(),
                2 => new ZaloPayPayment(),
                3 => new CashPayment(),
                4 => new BankTransferPayment(),
                _ => new NullPayment(),
            };
        }

        public class NullPayment : Payment
        {
            public override void Pay(double amount)
            {
                Console.WriteLine("Không có phương thức thanh toán được chọn.");
            }
        }

    }
}
