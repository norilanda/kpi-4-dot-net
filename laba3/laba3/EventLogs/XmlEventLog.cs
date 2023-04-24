using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace laba3.EventLogs
{
    public class XmlEventLog : EventLog
    {
        public override void Save(string fileName, List<Event> events)
        {
            XmlSerializer serializer = new XmlSerializer(events.GetType());
            using (StreamWriter sw = new StreamWriter(fileName))
            {
                serializer.Serialize(sw, events);
            }
        }
        public override List<Event> Load(string fileName)
        {
            List<Event> events = new List<Event>();
            XmlSerializer serializer = new XmlSerializer(events.GetType());
            using(StreamReader sr = new StreamReader(fileName))
            {
                events = (List<Event>)serializer.Deserialize(sr);
            }
            return events;
        }
    }
}
