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
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + " Insert a new date please (dd/mm/yyyy): ");
                DateTime newDate = DateTime.Parse(Console.ReadLine());
                return CheckDate(newDate);
            }
        }

        public void BookSeats(int numberOfSeatsToBook)
        {
            try
            {
                if ((this.bookedSeats += numberOfSeatsToBook) <= maxCapacity)
                {
                    this.bookedSeats += numberOfSeatsToBook;
                }
                else
                {
                    throw new ArgumentException("Overbooked!");
                }
            }
            catch (Exception e)
            {
                int overBookedSeats = (this.bookedSeats += numberOfSeatsToBook) - this.maxCapacity;
                this.bookedSeats = this.maxCapacity;
                Console.WriteLine(e.Message + " Booked Seats are maxed out! " + this.bookedSeats + "/" + this.maxCapacity);
                Console.WriteLine(overBookedSeats + " could not be booked");
            }
        }

        public void CancelSeats(int numberOfSeatsToCancel)
        {
            this.bookedSeats -= numberOfSeatsToCancel;
        }

        public int FreeSeats()
        {
            if (this.maxCapacity - this.bookedSeats >= 0)
            {
                return this.maxCapacity - this.bookedSeats;
            }
            return 0;
        }

        public override string ToString()
        {
            string eventRappresentation = "\t" + Date.ToString("dd/MM/yyyy") + " - " + Title;

            return eventRappresentation;
        }


    }
}
