using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.IUI;
using AbstractFactory.Dark;

namespace AbstractFactory.Factories
{
    public class DarkFactory : IUIFactory
    {
        public IButton CreateButton()
        {
            return new DarkButton();
        }

        public IMenu CreateMenu()
        {
            return new DarkMenu();
        }
    }
}
