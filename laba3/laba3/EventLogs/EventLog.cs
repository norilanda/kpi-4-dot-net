using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba3.EventLogs
{
    /// <summary>
    ///     Writing and reading event logs
    /// </summary>
    public abstract class EventLog
    {
        // creates a new file and store events there
        public abstract void CreateEventLog(string fileName, List<Event> events);
        // append events to the existing file or creates new if it doesn't exists
        public abstract void UpdateEventLog(string fileName, List<Event> events);
        // reads events from file
        public abstract List<Event> Load(string fileName);
    }
}
