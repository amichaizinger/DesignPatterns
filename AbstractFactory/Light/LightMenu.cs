using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.IUI;

namespace AbstractFactory.Light
{
    public class LightMenu : IMenu
    {
        public void Show()
        {
            Console.WriteLine("Light Menu");
        }
    }
}
