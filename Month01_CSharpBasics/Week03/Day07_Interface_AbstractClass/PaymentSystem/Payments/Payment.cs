using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiPaymentSystem.Payments
{
    public abstract class Payment
    {
        public abstract void Pay(double amount);
    }
}
