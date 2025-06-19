using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class Bike : INavigationStrategy
    {
        public void Navigate(string destination)
        {
            Console.WriteLine($"Navigating to {destination} by bike.");
        }
    }
}
