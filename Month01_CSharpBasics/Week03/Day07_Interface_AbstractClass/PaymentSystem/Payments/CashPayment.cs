using PaymentSystem.Core.Abstracts;
using PaymentSystem.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentSystem.Payments
{
    public class CashPayment : Payment, ICashPayment
    {
        public override void Pay(double amount)
        {
            Console.WriteLine($"Received cash payment: {amount:N0}");
            PrintReceipt();
        }

        public void PrintReceipt()
        {
            Console.WriteLine("Printing cash receipt...");
        }

        public void AcceptChange()
        {
            Console.WriteLine("Accepting change...");
        }
    }
}
