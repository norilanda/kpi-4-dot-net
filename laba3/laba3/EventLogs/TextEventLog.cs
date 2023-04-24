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
        public override void CreateEventLog(string fileName, List<Event> events)
        {
            string lines = TransformEventsToLines(events);
            File.WriteAllText(fileName, lines);
        }
        public override void UpdateEventLog(string fileName, List<Event> events)
        {
            string lines = "";
            if (File.Exists(fileName) && new FileInfo(fileName).Length > 0)
                lines = "\n" + TransformEventsToLines(events);
            else
                lines = TransformEventsToLines(events);
            try
            {
                using (StreamWriter sw = File.AppendText(fileName))
                {
                    sw.Write(lines);
                }
            }
            catch { throw; }
        }
        public override List<Event> Load(string fileName)
        {
            try
            {
                string lines = File.ReadAllText(fileName);
                List<Event> events = TransformLinesToEvents(lines);
                return events;
            }
            catch { throw; }
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
            try
            {
                while (i < linesArray.Length)
                {
                    level = Enum.Parse< LevelType>(linesArray[i++]);
                    source = linesArray[i++];
                    date = DateTime.Parse(linesArray[i++]);
                    message = linesArray[i++];
                    events.Add(new Event(level, source, date, message));
                }
                return events;
            }
            catch  { throw new ArgumentException("The data in file seems to be corrupted! Cannot operate on file!"); }
        }
    }
}
