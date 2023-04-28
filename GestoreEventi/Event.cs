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
        private readonly int bookedSeats;

        public Event(string title, string date, int maxCapacity, int bookedSeats)
        {
            this.title = title;
            this.maxCapacity = maxCapacity;
            Date = DateTime.Parse(date);
            try
            {
                if (bookedSeats > maxCapacity)
                {
                    throw new ArgumentException("Number of booking above max Capacity!");
                }
            } catch (Exception e)
            {
                Console.WriteLine(e.Message + " " + e.TargetSite);
            }
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public DateTime Date
        {
            get { return date; }
            set 
            {
                try
                {
                    if (value < DateTime.Today)
                    {
                        throw new ArgumentException("Date already passed!");
                    }
                    date = value;
                } catch (Exception e)
                {
                    Console.WriteLine(e.Message + " " + e.TargetSite);
                }
            }
        }

        public int MaxCapacity
        {
            get { return maxCapacity; }
        }

        public int BookedSeats
        {
            get { return bookedSeats; }
        }



    }
}
