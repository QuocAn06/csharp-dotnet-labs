using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiPaymentSystem.Interfaces
{
    public interface IOnlinePayment
    {
        void Authenticate(); // Bắt buộc online phải xác thực
    }
}
