using PaymentSystem.Core.Abstracts;
using PaymentSystem.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentSystem.Payments
{
    public class MomoPayment: Payment, IOnlinePayment
    {
        public string PhoneNumber {  get; set; }

        public override void Pay(double amount)
        {
            VerifyPaymentMethod();
            Console.WriteLine($"Paid {amount:N0} via Momo from {PhoneNumber}");
        }

        public void VerifyPaymentMethod()
        {
            Console.WriteLine($"Verifying Momo account: {PhoneNumber}");
        }

        public string GetPaymentMethod() => "Momo Gateway";
    }
}
