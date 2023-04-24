﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba3.EventLogs
{
    public abstract class EventLog
    {
        public abstract void CreateEventLog(string fileName, List<Event> events);
        public abstract void UpdateEventLog(string fileName, List<Event> events);
        public abstract List<Event> Load(string fileName);
    }
}
