using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Bevande
{
    public class EspressoBeverage : IBeverage
    {
        public double GetCost()
        {
            return 1.40;
        }

        public string GetDescription()
        {
            return "Espresso";
        }
    }
}
