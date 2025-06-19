using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.IUI;

namespace AbstractFactory.Dark
{
    public class DarkMenu : IMenu
    {
        public void Show()
        {
            Console.WriteLine("Dark Menu");
        }
    }
}
