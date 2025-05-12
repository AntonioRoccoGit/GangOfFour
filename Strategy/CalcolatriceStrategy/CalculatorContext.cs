using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.CalcolatriceStrategy
{
    class CalculatorContext(IOperationStrategy strategy)
    {
        private IOperationStrategy _strategy = strategy;

        public void SetStrategy(IOperationStrategy strategy)
        {
            this._strategy = strategy;
        }

        public float Calculate(float a, float b)
        {
            return _strategy.Execute(a, b);
        }
    }
}
