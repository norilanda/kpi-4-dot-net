using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using laba3.EventLogs;

namespace laba3
{
    public static class EventLogFactory
    {
        public static EventLog Create(string fileName)
        {
            string extention = Path.GetExtension(fileName);
            switch (extention)
            {
                case ".txt": return new TextEventLog();
                case ".xml": return new XmlEventLog();
                default: throw new ArgumentException("file type cannot be processed");
            }
        }
    }
}
