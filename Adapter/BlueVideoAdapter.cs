using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class BlueVideoAdapter : IChangeColor
    {
        private OldChangeToBlue _blue;
        public BlueVideoAdapter(OldChangeToBlue blue)
        {
            _blue = blue;
        }

        public void ChangeColor(Video video)
        {
            Console.WriteLine("Changing color to blue.");
        }
    }
}
