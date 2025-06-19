using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.IUI;

namespace AbstractFactory.Dark
{
    public class DarkButton : IButton
    {
        public void Render()
        {
            Console.WriteLine("Dark Button");
        }
    }
}
