using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static laba3.Event;
using static System.Net.Mime.MediaTypeNames;

namespace laba3.EventOperations
{
    public static class EventGenerator
    {
        private static Dictionary<string, List<string>> sourcesInfo = new Dictionary<string, List<string>>  {
            { "RestartManager", new List<string>() { "Ending session 1 started ", "Starting session 1" } },
            { "DockerService", new List<string>() { "PowerEvent handled successfully by the service." } },
            { "EventSystem", new List<string>() { "The EventSystem sub system is suppressing duplicate event log entries for a duration of 86400 seconds." } },
            { "File Server", new List<string>() { "File \"report.docx\" has been uploaded to the server", "File \"config.txt\" has been uploaded to the server", "File \"requirements.txt\" has been uploaded to the server" } },

        };
        private static Dictionary<string, List<string>> sourcesWarning = new Dictionary<string, List<string>>
        {
            { "MyApp", new List<string>() { "WARNING: Low disk space on drive C:\\" } },
            { "Database", new List<string>() { "WARNING: Connection timeout to server" } },
            { "Security", new List<string>() { "WARNING: Low disk space on drive C:\\" } },
            { "Network", new List<string>() { "WARNING: Network connection lost" } },
        };
        private static Dictionary<string, List<string>> sourcesError = new Dictionary<string, List<string>>
        {
            { ".NET Runtime", new List<string>() { "The process was terminated due to an unhandled exception."} },
            { "Application Error", new List<string>() { "Faulting application MyApp.exe, version 1.0.0.0" } },
            { "Service Control Manager", new List<string>() { "The MyService service failed to start" } },

            { "Disk", new List<string>() { "An error was detected on device \\Device\\Harddisk2\\DR2 during a paging operation." } },
            { "VSS", new List<string>() { "The COM Server cannot be started",
                                          "Unexpected error calling routine CoCreateInstance"} }
        };

        private static Random random = new Random();
        public static List<Event> Generate(int numberOfEvents)
        {
            List<Event> events = new List<Event>();
            LevelType level;
            string source, message;
            DateTime date = DateTime.Now.AddHours(-4);

            Array values = Enum.GetValues(typeof(LevelType));

            for (int i = 0; i < numberOfEvents; i++)
            {
                level = (LevelType)values.GetValue(random.Next(values.Length));
                date = date.AddMinutes(random.Next(15));
                GetSourceAndMessageBasedOnLevel(level, out source, out message);
                events.Add(new Event(level, source, date, message));
            }
            return events;
        }
        private static void GetSourceAndMessageBasedOnLevel(LevelType level, out string source, out string message)
        {
            Dictionary<string, List<string>> sources;
            switch (level)
            {
                case LevelType.Information:
                    {
                        sources = sourcesInfo;
                        break;
                    }
                case LevelType.Warning:
                    {
                        sources = sourcesWarning;
                        break;
                    }
                default:
                    {
                        sources = sourcesError;
                        break;
                    }
            }
            source = sources.ElementAt(random.Next(sources.Count())).Key;
            message = sources[source][random.Next(sources[source].Count)];
        }
    }
}