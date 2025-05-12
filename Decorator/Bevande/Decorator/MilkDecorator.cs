using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Bevande.Decorator
{
    class MilkDecorator(IBeverage wrappee) : BeverageAbstractDecorator(wrappee)
    {

        public override string GetDescription()
        {
            var description = $"{base.GetDescription()}, Latte";
            return description;
        }

        public override double GetCost()
        {
            double price = 0.30;
            return base.GetCost() + price;
        }

    }
}
