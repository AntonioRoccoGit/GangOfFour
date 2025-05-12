using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Bevande
{
    public interface IBeverage
    {
        string GetDescription();
        double GetCost();
    }
}
