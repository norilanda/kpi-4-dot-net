using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba3.EventOperations
{
    public static class EventProcessor
    {
        public static List<Event> TakeLastEvents(List<Event> events, int numberToTake)
        {
            return events.OrderByDescending(e => e.DateAndTime)
                  .Take(numberToTake).ToList();
        }
    }
}
