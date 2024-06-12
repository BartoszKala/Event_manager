using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_manager.Models
{
    public interface IEventRepository
    {
        void Add(Event new_event);
        void Remove(Event new_event);
        void Save(string filePath);
        void Load(string filePath);
        void Sort(string attributeName, SortOrder sortOrder);
        public void Filter(DateTime startDate, DateTime endDate, bool highPriority, bool mediumPriority, bool lowPriority, bool family, bool entertainment, bool sports, bool health, bool work);
        

            IEnumerable<Event> GetAll();
    }
}
