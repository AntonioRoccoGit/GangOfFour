using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Bevande.Decorator
{
    public class SugarDecorator(IBeverage wrappee) : BeverageAbstractDecorator(wrappee)
    {

        public override double GetCost()
        {
            return base.GetCost();
        }

        public override string GetDescription()
        {
            var description = $"{base.GetDescription()}, Zucchero"; 
            return description;
        }
    }
}
