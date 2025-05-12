using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.PaymentStrategy
{
    public interface IPaymentStrategy
    {
        public void Paga(float amount);
    }
}
