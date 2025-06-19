using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class ChangeToRed : IChangeColor
    {
        public void ChangeColor(Video video)
        {
            Console.WriteLine("Changing color to red.");
        }
    }
}
