using events;
using GestoreEventi;
using System.Reflection.Metadata.Ecma335;
using System.Xml.Linq;

// INITIALIZING EVENT PROGRAM
Console.WriteLine("---------------------------- WELCOME ----------------------------\n");

Console.WriteLine("Type event list title: ");
string title = Console.ReadLine();
EventProgram eventProgram = new(title);



// POPULATING EVENT LIST WITH EVENTS
Console.WriteLine("How many events would you like to add? ");
int numberOfEventsToAdd = int.Parse(Console.ReadLine());

for (int i = 0; i < numberOfEventsToAdd; i++)
{
    Console.WriteLine("Type the event name: ");
    string eventName = Console.ReadLine();

    Console.WriteLine("Type the event date (dd/mm/yyyy): ");
    string eventDate = Console.ReadLine();

    Console.WriteLine("Type the event max capacity: ");
    int eventMaxCapacity = int.Parse(Console.ReadLine());

    Event newEvent = new(eventName, eventDate, eventMaxCapacity);

    Console.WriteLine("How many seats are booked?");
    int eventBookedSeats = int.Parse(Console.ReadLine());
    newEvent.BookSeats(eventBookedSeats);

    Console.WriteLine("\nThe number of booked seats is: " + newEvent.BookedSeats);
    Console.WriteLine("The number of free seats is: " + newEvent.FreeSeats() + "\n");

    eventProgram.AddEventToList(newEvent);
}



// POPULATING EVENT LIST WITH CONFERENCES
Console.WriteLine("How many conferences would you like to add? ");
int numberOfConferencesToAdd = int.Parse(Console.ReadLine());

for (int i = 0; i < numberOfConferencesToAdd; i++)
{
    Console.WriteLine("Type the conference name: ");
    string eventName = Console.ReadLine();

    Console.WriteLine("Type the conference date (dd/mm/yyyy): ");
    string eventDate = Console.ReadLine();

    Console.WriteLine("Type the conference speaker: ");
    string eventSpeaker = Console.ReadLine();

    Console.WriteLine("Type the conference ticket price: ");
    double eventTicketPrice = double.Parse(Console.ReadLine());

    Console.WriteLine("Type the conference max capacity: ");
    int eventMaxCapacity = int.Parse(Console.ReadLine());

    Conference newConference = new(eventName, eventDate, eventMaxCapacity, eventSpeaker, eventTicketPrice);

    Console.WriteLine("How many seats are booked?");
    int eventBookedSeats = int.Parse(Console.ReadLine());
    newConference.BookSeats(eventBookedSeats);

    Console.WriteLine("\nThe number of booked seats is: " + newConference.BookedSeats);
    Console.WriteLine("The number of free seats is: " + newConference.FreeSeats() + "\n");

    eventProgram.AddEventToList(newConference);
}



// GENERAL INFO
Console.WriteLine("Number of events in the list: " + eventProgram.EventsCount());
Console.WriteLine(eventProgram.ToString());



// RESEARCH BY DATE
Console.WriteLine("Type a date to know which events are going to be held (dd/mm/yyyy): ");
DateTime dateToResearch = Event.CheckDate(DateTime.Parse(Console.ReadLine()));

List<Event> eventsInDateToResearch = eventProgram.GetEventsInADate(dateToResearch);

if (eventsInDateToResearch.Count != 0)
{
    Console.WriteLine(EventProgram.GetEventsRappresentation(eventsInDateToResearch));
} else
{
    Console.WriteLine("No events found!");
}






