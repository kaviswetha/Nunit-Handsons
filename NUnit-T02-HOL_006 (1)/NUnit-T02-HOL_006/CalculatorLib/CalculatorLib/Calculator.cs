using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLib
{
    public class Calculator
    {
        public int Divide(int dividend,int devisor)
        {
            if (devisor == 0)
                throw new ArgumentNullException("Devisor cannot be null");
            return dividend / devisor;
        }
    }
}
