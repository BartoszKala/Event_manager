using Event_manager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_manager.Views
{
    public interface IEventView
    {
        // Właściowości
        string EventName { get; set; }
        string EventDescription { get; set; }
        string EventType { get; set; }
        string EventPriority { get; set; }
        DateTime EventDate { get; set; }

        // Zdarzenia
        event EventHandler AddNewEventEvent;
        event EventHandler RemoveEventEvent;
        event EventHandler SaveEventEvent;
        event EventHandler LoadEventEvent;
        event EventHandler SortEventEvent;
        event EventHandler FilterEventEvent;

        // Metody
        void SetEventListBindingSource(BindingSource eventList);

        Event GetSelectedEvent();

        string GetColumnName();


        //public bool FilterFamily { get; }
        //public bool FilterEntertainment { get; }
        //public bool FilterSports { get; }
        //public bool FilterHealth { get; }
        //public bool FilterWork { get; }

    }
}
