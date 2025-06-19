// See https://aka.ms/new-console-template for more information
using AbstractFactory;
using AbstractFactory.Factories;
using AbstractFactory.IUI;

Console.WriteLine("enter light or dark for UI settings");
string uiSetting = Console.ReadLine();

IUIFactory uiFactory = null;

switch (uiSetting)
    {
    case "light":
        Console.WriteLine("Light UI selected");
        uiFactory = new LightUIFactory();
        break;
    case "dark":
        Console.WriteLine("Dark UI selected");
        uiFactory =  new DarkFactory();
        break;
    default:
        Console.WriteLine("Invalid UI setting");
        break;
}
UI uI = new UI(uiFactory);
uI.RenderUI();