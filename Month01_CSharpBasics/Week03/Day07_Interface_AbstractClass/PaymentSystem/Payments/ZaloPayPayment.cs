using MultiPaymentSystem.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiPaymentSystem.Payments
{
    public class ZaloPayPayment : Payment, IOnlinePayment
    {
        public override void Pay(double amount)
        {
            Authenticate();
            Console.WriteLine($"Success! {amount:N0} VND paid via ZaloPay");
        }

        public void Authenticate()
        {
            Console.WriteLine("ZaloPayment account verified successfully!");
        }

       
    }
}
