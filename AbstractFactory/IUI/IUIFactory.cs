using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.IUI
{
    public interface IUIFactory
    {
        IButton CreateButton();
        IMenu CreateMenu();
    }
}
