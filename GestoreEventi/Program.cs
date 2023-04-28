using events;
using GestoreEventi;
using System.Reflection.Metadata.Ecma335;
using System.Xml.Linq;

/*
Console.WriteLine("=========================== WELCOME ===========================");
Console.WriteLine("Type the event name: ");
string name = Console.ReadLine();
Console.WriteLine("Type the event date (dd/mm/yyyy): ");
string date = Console.ReadLine();
Console.WriteLine("Type the event max capacity: ");
int maxCapacity = int.Parse(Console.ReadLine());
Event newEvent = new(name, date, maxCapacity);

Console.WriteLine("Do you want to book some seats? [y] [n]");
char userChoice = char.Parse(Console.ReadLine());
if (Selector(userChoice))
{
    Console.WriteLine("How many seats should be booked? ");
    int numberOfSeatsToBook = int.Parse(Console.ReadLine());
    newEvent.BookSeats(numberOfSeatsToBook);
}

Console.WriteLine("Number of booked seats: " + newEvent.BookedSeats);
Console.WriteLine("Number of free seats: " + newEvent.FreeSeats());

Console.WriteLine("Do you want to cancel some seats reservation? [y] [n]");
userChoice = char.Parse(Console.ReadLine());
if (Selector(userChoice))
{
    Console.WriteLine("How many seats reservation should be cancelled? ");
    int numberOfSeatsToCancel = int.Parse(Console.ReadLine());
    newEvent.CancelSeats(numberOfSeatsToCancel);
}
Console.WriteLine("Number of booked seats: " + newEvent.BookedSeats);
Console.WriteLine("Number of free seats: " + newEvent.FreeSeats());
*/

Event newEvent = new("daw", "12/12/2025", 50);
Event newEven2t = new("daw", "12/12/2025", 50);

EventProgram newEventProgram = new("Title");
newEventProgram.AddEventToList(newEvent);
newEventProgram.AddEventToList(newEven2t);
Console.WriteLine(newEventProgram.ToString());










// ========================== FUNCTIONS ==========================

/*
static bool Selector(char choice)
{
    if (choice == 'y' || choice == 'Y')
    {
        return true;
    } else
    {
        return false;
    }
}
*/