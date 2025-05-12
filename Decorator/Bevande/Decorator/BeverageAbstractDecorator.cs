using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Bevande.Decorator
{
    public class BeverageAbstractDecorator(IBeverage wrappee) : IBeverage
    {
        protected IBeverage _wrappee = wrappee;
        public virtual double GetCost()
        {
            return _wrappee.GetCost();
        }

        public virtual string GetDescription()
        {
            return _wrappee.GetDescription();
        }
    }
}
