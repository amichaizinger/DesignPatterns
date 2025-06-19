using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.IUI;

namespace AbstractFactory.Light
{
    public class lightButton : IButton
    {
        public void Render()
        {
            Console.WriteLine("Light Button");
        }
    }
}
