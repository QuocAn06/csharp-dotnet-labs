using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentSystem.Core.Abstracts
{
    public abstract class Payment
    {
        public abstract void Pay(double amount);
        public string TransactionId { get; } = Guid.NewGuid().ToString();
    }
}
