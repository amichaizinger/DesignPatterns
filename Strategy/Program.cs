// See https://aka.ms/new-console-template for more information
using Strategy;

Console.WriteLine("Enter a navigation strategy: 'walk', 'ride', or 'bike'");
string strategyInput = Console.ReadLine()?.ToLower();

INavigationStrategy navigationStrategy = null;

switch(strategyInput)
{
    case "walk":
        navigationStrategy = new Walk();
        break;
    case "bike":
        navigationStrategy = new Bike();
        break;
    case "ride":
        navigationStrategy = new Ride();
        break;
    default:
        Console.WriteLine("Invalid strategy. Defaulting to WalkStrategy.");
        navigationStrategy = new Walk();
        break;
}
Navigator navigator = new Navigator(navigationStrategy);
Console.WriteLine("Enter a destination:");
string destination = Console.ReadLine();
navigator.Navigate(destination);
