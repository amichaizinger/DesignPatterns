using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class Walk : INavigationStrategy
    {
        public void Navigate(string destination)
        {
            Console.WriteLine($"Walking to {destination}.");
        }
    }
   
}
