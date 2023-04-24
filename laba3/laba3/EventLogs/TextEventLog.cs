using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static laba3.Event;

namespace laba3.EventLogs
{
    public class TextEventLog : EventLog
    {
        public override void Save(string fileName, List<Event> events)
        {
            string lines = TransformEventsToLines(events);
            File.WriteAllText(fileName, lines);
        }
        public override List<Event> Load(string fileName)
        {
            string lines = File.ReadAllText(fileName);
            List<Event> events = TransformLinesToEvents(lines);
            return events;
        }
        private string TransformEventsToLines(List<Event> events)
        {
            StringBuilder strbuild = new StringBuilder();
            foreach (Event e in events)
            {
                strbuild.Append(e.Level.ToString() + "\n");
                strbuild.Append(e.Source + "\n");
                strbuild.Append(e.DateAndTime.ToString() + "\n");
                strbuild.Append(e.Message + "\n");
            }
            return strbuild.ToString().Trim('\n');
        }
        private List<Event> TransformLinesToEvents(string lines)
        {
            List<Event> events = new List<Event>();
            string[] linesArray = lines.Split('\n');
            LevelType level;
            string source, message;
            DateTime date;

            int i = 0;
            while(i < linesArray.Length)
            {
                Enum.TryParse(linesArray[i++], out level);
                source = linesArray[i++];
                date = DateTime.Parse(linesArray[i++]);
                message = linesArray[i++];
                events.Add(new Event(level, source, date, message));
            }
            return events;
        }
    }
}
