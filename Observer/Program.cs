// See https://aka.ms/new-console-template for more information
using Observer;

Console.WriteLine("oi vey zmir, did something happen? write what was it so we can wake the people in the middle of the night");
string incidentDetails = Console.ReadLine();

Console.WriteLine("Thank you for reporting the incident. We will look into it as soon as possible.");


IObserver phone = new Phone();
IObserver alarm = new Alarm();
var criticalIncidents = new CriticalIncidents();

criticalIncidents.RegisterObserver(alarm);
criticalIncidents.RegisterObserver(phone);

criticalIncidents.SendMessage(incidentDetails);