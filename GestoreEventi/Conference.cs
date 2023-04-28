using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using events;

namespace GestoreEventi;

public class Conference : Event
{
    private string speaker;
    private double price;

    public Conference(string title, string date, int maxCapacity, string speaker, double price) : base(title, date, maxCapacity)
    {
        this.speaker = speaker;
        this.price = double.Parse(price.ToString("0.00"));
    }

    public string Speaker { get { return speaker; } set { speaker = value;  } }
    public double Price { get { return price; } set { price = value; } }

    public override string ToString()
    {
        string eventRappresentation = "\t" + Date.ToString("dd/MM/yyyy") + " - " + Title + " - " + speaker + " - " + price + " euro";

        return eventRappresentation;
    }

}
