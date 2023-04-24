using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace laba3.EventLogs
{
    public class XmlEventLog : EventLog
    {
        public override void CreateEventLog(string fileName, List<Event> events)
        {
            XmlSerializer serializer = new XmlSerializer(events.GetType());
            using (StreamWriter sw = new StreamWriter(fileName))
            {
                serializer.Serialize(sw, events);
            }
        }
        public override void UpdateEventLog(string fileName, List<Event> events)
        {
            try
            {
                if (File.Exists(fileName))
                {
                    XDocument data = XDocument.Load(fileName);
                    if (data.Descendants("Event").Any())
                    {
                        List<XElement> xElements = TransformEventsToXElements(events);
                        data.Descendants("Event")
                            .LastOrDefault()
                            .AddAfterSelf(xElements);
                        data.Save(fileName);
                    }
                    else
                        CreateEventLog(fileName, events);
                }
                else
                    CreateEventLog(fileName, events);
            }
            catch (XmlException)
            {
                CreateEventLog(fileName, events);
            }
        }
        public override List<Event> Load(string fileName)
        {
            List<Event> events = new List<Event>();
            XmlSerializer serializer = new XmlSerializer(events.GetType());
            try
            {
                using (StreamReader sr = new StreamReader(fileName))
                {
                    events = (List<Event>)serializer.Deserialize(sr);
                }
                return events;
            }
            catch { throw; }
        }
        private List<XElement> TransformEventsToXElements(List<Event> events)
        {
            List<XElement> result = new List<XElement>();
            foreach (Event e in events)
            {
                result.Add(new XElement("Event",
                                new XElement("Level", e.Level),
                                new XElement("Source", e.Source),
                                new XElement("DateAndTime", e.DateAndTime),
                                new XElement("Message", e.Message)
                                ));
            }
            return result;
        }
    }
}
