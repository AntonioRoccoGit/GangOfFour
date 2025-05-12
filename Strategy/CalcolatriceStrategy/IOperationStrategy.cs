using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.CalcolatriceStrategy
{
    public  interface IOperationStrategy
    {
        public float Execute(float a, float b);
    }
}
