using MultiPaymentSystem.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiPaymentSystem.Payments
{
    public class CashPayment : Payment, ICashPayment
    {
        public override void Pay(double amount)
        {
            VerifyCash();
            Console.WriteLine($"Cash received: {amount:N0} VND.");
        }

        public void VerifyCash()
        {
            Console.WriteLine("Cash verification...");
        }
    }
}
