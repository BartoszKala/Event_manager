using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_manager.Models
{
    public class Event
    {
        public string Nazwa { get; set; }
        public string Opis { get; set; }
        public string Rodzaj { get; set; }
        public string Priorytet { get; set; }
        public DateTime Data { get; set; }

        public override string ToString()
        {
            return $"Nazwa: {Nazwa}, Opis: {Opis}, Rodzaj: {Rodzaj}, Priorytet: {Priorytet}, Data: {Data}";
        }

        public Event(string name, string description, string type, string priority, DateTime date)
        {
            if(date<DateTime.Now) date = DateTime.Now;  

            Nazwa = name;
            Opis = description;
            Rodzaj = type;
            Priorytet = priority;
            Data = date;
        }

        public Event(Event new_event)
        {

            Nazwa = new_event.Nazwa;
            Opis = new_event.Opis;
            Rodzaj = new_event.Rodzaj;
            Priorytet = new_event.Priorytet;
            Data = new_event.Data;
        }

        public Event() { }
    }

}
