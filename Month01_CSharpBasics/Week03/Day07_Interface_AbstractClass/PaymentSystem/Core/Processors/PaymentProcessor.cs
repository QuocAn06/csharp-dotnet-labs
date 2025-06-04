using PaymentSystem.Core.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentSystem.Core.Processors
{
    public class PaymentProcessor
    {
        public void Process(Payment payment, double amount)
        {
            Console.WriteLine($"\nProcessing transaction {payment.TransactionId}");
            payment.Pay(amount);
            Console.WriteLine("Transaction completed\n");
        }
    }
}
