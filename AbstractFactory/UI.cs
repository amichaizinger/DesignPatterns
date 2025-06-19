using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.IUI;

namespace AbstractFactory
{
    public class UI
    {
        private IUIFactory _uiFactory;

        public UI(IUIFactory uiFactory)
        {
            _uiFactory = uiFactory;
        }

        public void RenderUI()
        {
            IButton button = _uiFactory.CreateButton();
            IMenu menu = _uiFactory.CreateMenu();
            button.Render();
            menu.Show();
        }
    }
}
