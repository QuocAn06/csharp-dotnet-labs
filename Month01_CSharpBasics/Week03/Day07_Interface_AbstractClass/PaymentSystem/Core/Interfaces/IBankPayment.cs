using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentSystem.Core.Interfaces
{
    public interface IBankPayment
    {
        void ProcessBankDetails();
        void VerifyAccountBalance(double amount);
    }
}
