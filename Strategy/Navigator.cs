using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class Navigator
    {
        public INavigationStrategy Strategy { get; set; }

        public Navigator(INavigationStrategy strategy)
        {
            Strategy = strategy ?? throw new ArgumentNullException(nameof(strategy), "Strategy cannot be null");
        }


        public void Navigate(string destination)
        { 
            Strategy.Navigate(destination);
        }

    }

}
