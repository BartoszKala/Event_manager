using Event_manager.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace Event_manager.Repository
{
    public class EventRepository : IEventRepository
    {
        // baza wydarzeń - imitacja bazy danych
        private List<Event> eventsDatabase;

        // konstruktor
        public EventRepository()
        {
            eventsDatabase = new List<Event>()
        {
            //new Event("Urodziny wójka", "Kup prezent", "Rodzina", "Wysoki", DateTime.Now),
            //new Event("Badanie wzroku", "", "Zdrowie", "Średni", DateTime.Now),
            //new Event("Projekt", "dokończ", "Praca", "Niski", DateTime.Now)
        };
        }

        public IEnumerable<Event> GetAll()
        {
            var eventList = new List<Event>();

            foreach (var new_event in eventsDatabase)
            {
                eventList.Add(new_event);
            }

            return eventList;
        }

        public void Add(Event new_event)
        {
            eventsDatabase.Add(new_event);
        }

        public void Remove(Event new_event)
        { 
            eventsDatabase.Remove(new_event);
        }

        public void Save(string filePath)
        {
            string jsonData = JsonConvert.SerializeObject(eventsDatabase);
            File.WriteAllText(filePath, jsonData);
        }

        public void Load(string filePath)
        {
            try
            {
                eventsDatabase.Clear();
                string jsonData = File.ReadAllText(filePath);
                List<Event> loadedEvents = JsonConvert.DeserializeObject<List<Event>>(jsonData);

                eventsDatabase.AddRange(loadedEvents);

            }
            catch (Exception ex)
            {
                eventsDatabase.Clear();
                throw new Exception($"Błąd wczytywania danych z pliku: {ex.Message}");
            }
        }

        public void Sort(string columnName, SortOrder sortOrder)
        {
            switch (columnName)
            {
                case "Nazwa":
                    eventsDatabase = sortOrder == SortOrder.Ascending ?
                                     eventsDatabase.OrderBy(e => e.Nazwa).ToList() :
                                     eventsDatabase.OrderByDescending(e => e.Nazwa).ToList();
                    break;
                case "Opis":
                    eventsDatabase = sortOrder == SortOrder.Ascending ?
                                     eventsDatabase.OrderBy(e => e.Opis).ToList() :
                                     eventsDatabase.OrderByDescending(e => e.Opis).ToList();
                    break;
                case "Rodzaj":
                    eventsDatabase = sortOrder == SortOrder.Ascending ?
                                     eventsDatabase.OrderBy(e => e.Rodzaj).ToList() :
                                     eventsDatabase.OrderByDescending(e => e.Rodzaj).ToList();
                    break;
                case "Priorytet":
                    eventsDatabase = sortOrder == SortOrder.Ascending ?
                                     eventsDatabase.OrderBy(e => e.Priorytet).ToList() :
                                     eventsDatabase.OrderByDescending(e => e.Priorytet).ToList();
                    break;
                case "Data":
                    eventsDatabase = sortOrder == SortOrder.Ascending ?
                                     eventsDatabase.OrderBy(e => e.Data).ToList() :
                                     eventsDatabase.OrderByDescending(e => e.Data).ToList();
                    break;
                default:
                    throw new ArgumentException("Nieprawidłowa nazwa kolumny do sortowania.");
            }
        }

        public void Filter(DateTime startDate, DateTime endDate, bool highPriority, bool mediumPriority, bool lowPriority, bool family, bool entertainment, bool sports, bool health, bool work)
        {
            var filteredEvents = eventsDatabase.Where(e =>
                (startDate == null || e.Data >= startDate) &&
                (endDate == null || e.Data <= endDate) &&
                (!highPriority || e.Priorytet == "Wysoki") &&
                (!mediumPriority || e.Priorytet == "Średni") &&
                (!lowPriority || e.Priorytet == "Niski") &&
                (!family || e.Rodzaj == "Rodzina") &&
                (!entertainment || e.Rodzaj == "Rozrywka") &&
                (!sports || e.Rodzaj == "Sport") &&
                (!health || e.Rodzaj == "Zdrowie") &&
                (!work || e.Rodzaj == "Praca")
            ).ToList();

            eventsDatabase = filteredEvents;// trzeba zrobic aby tworzyl kopie
        }

    }
}
