// See https://aka.ms/new-console-template for more information
using Adapter;

Console.WriteLine("choose red or blue to change video to");
string color = Console.ReadLine();

Video video = new Video("123", "123", 123);
IChangeColor changeColor = null;

switch (color)
{
    case "red":
        changeColor = new ChangeToRed();
        break;
    case "blue":
        changeColor = new BlueVideoAdapter(new OldChangeToBlue());
        break;
    default:
        Console.WriteLine("Invalid color choice");
        break;
}
 changeColor?.ChangeColor(video);