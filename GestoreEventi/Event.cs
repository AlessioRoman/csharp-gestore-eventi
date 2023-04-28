using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace events
{
    public class Event
    {
        private string title;
        private DateTime date;
        private readonly int maxCapacity;
        private int bookedSeats;

        public Event(string title, string date, int maxCapacity)
        {
            this.title = title;
            this.date = CheckDate(DateTime.Parse(date));
            this.maxCapacity = maxCapacity;
            this.bookedSeats = 0;
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public DateTime Date
        {
            get { return date; }
            set { date = CheckDate(value); }
        }

        public int MaxCapacity
        {
            get { return maxCapacity; }
        }

        public int BookedSeats
        {
            get { return bookedSeats; }
        }

        public static DateTime CheckDate(DateTime date)
        {
            try
            {
                if (date < DateTime.Today)
                {
                    throw new ArgumentException("Date already passed!");
                }
                return date;
            } catch(Exception e) 
            { 
                Console.WriteLine(e.Message + " Insert a new date please (dd/mm/yyyy): ");
                DateTime newDate = DateTime.Parse(Console.ReadLine());
                return CheckDate(newDate);
            }
        }

        public void BookSeats(int numberOfSeatsToBook)
        {
            this.bookedSeats += numberOfSeatsToBook;
        }

        public void CancelSeats(int numberOfSeatsToCancel)
        {
            this.bookedSeats -= numberOfSeatsToCancel;
        }

        public override string ToString()
        {
            string eventRappresentation = "\t" + Date.ToString("dd/MM/yyyy") + " - " + Title;

            return eventRappresentation;
        }


    }
}
