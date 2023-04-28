using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using events;

namespace GestoreEventi
{
    public class EventProgram
    {
        private string title;
        private List<Event> Events;

        public EventProgram(string title)
        {
            this.title = title;
            this.Events = new();
        }
        public string Title { get { return title; } set { title = value; } }

        public void AddEventToList(Event newEvent)
        {
            Events.Add(newEvent);
        }

        public List<Event> GetEventsInADate(DateTime date)
        {
            List<Event> newList = new();
            foreach (Event e in Events)
            {
                if (e.Date == date)
                {
                    newList.Add(e);
                }
            }
            return newList;
        }

        public static string GetEventsRappresentation(List<Event> list)
        {
            string listRappresentation = "------------ EVENTS ------------";
            foreach (Event e in list) 
            {
                listRappresentation += "\n" + e.ToString();
            }
            return listRappresentation;
        }

        public int EventsCount()
        {
            return Events.Count;
        }

        public void EmptyList() 
        {
            Events.Clear();
        }

        public override string ToString()
        {
            string eventProgramRappresentation = $"------------------------ {Title.ToUpper()} ------------------------\n" +
            "\n" +
            GetEventsRappresentation(Events) + "\n";

            return eventProgramRappresentation;
        }
    }
}
