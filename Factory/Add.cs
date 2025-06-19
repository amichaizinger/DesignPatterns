using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    internal class Add : ICalculate
    {
        public void Calculate(double a, double b)
        {
            Console.WriteLine($"A + B = {(a + b)}");
        }
    }
}
