using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Factory;

namespace DesignFactory.Factory
{
    public class Factory
    {
        public ICalculate GetCalculator(string operation)
        {
            ICalculate calculator = null;

            switch (operation.ToLower())
            {
                case "add":
                    return new Add();
                case "subtract":
                    return new Subtract();
                case "multiply":
                    return new Multiply();
                case "divide":
                    return new Devide();
                default:
                    throw new ArgumentException("Invalid operation type");
            }
        }
    }
}

