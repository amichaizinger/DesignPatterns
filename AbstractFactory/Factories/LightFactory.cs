using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.IUI;
using AbstractFactory.Light;

namespace AbstractFactory.Factories
{
    public class LightUIFactory : IUIFactory
    {
        public IButton CreateButton()
        {
            return new lightButton();
        }

        public IMenu CreateMenu()
        {
            return new LightMenu();
        }
    }
}
