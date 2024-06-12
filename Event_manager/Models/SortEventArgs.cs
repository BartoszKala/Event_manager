using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_manager.Models
{
    public class SortEventArgs : EventArgs
    {
        public string ColumnName { get; }
        public SortOrder SortOrder { get; }

        public SortEventArgs(string columnName, SortOrder sortOrder)
        {
            ColumnName = columnName;
            SortOrder = sortOrder;
        }
    }
}
