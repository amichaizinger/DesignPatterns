// See https://aka.ms/new-console-template for more information
Console.WriteLine("enter a number");
int a = Console.Read();
Console.WriteLine("enter another number");
int b = Console.Read();
Console.WriteLine("enter an operation: +, -, *, /");
string operation = Console.ReadLine();
Factory.ICalculate calculator = null;

