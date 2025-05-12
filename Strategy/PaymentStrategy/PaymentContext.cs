using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.PaymentStrategy
{
    public class PaymentContext(IPaymentStrategy strategy)
    {
        private IPaymentStrategy _strategy = strategy;

        public void SetStrategy(IPaymentStrategy strategy)
        {
            _strategy = strategy;
        }

        public void Execute(float amount)
        {
            _strategy.Paga(amount);
        }
    }
}
