using laba3.EventLogs;
using laba3.EventOperations;

namespace laba3
{
    //    4) Реалізувати задачу протоколювання подій.Журнал подій може мати декілька форматів, котрий задається з самого початку (наприклад,
    //текстовий файл, XML, тощо). Події, котрі надсилаються в журнал повинні мати наступні характеристики:
    //  - рівень важливості подій (нормальний, зауваження, помилка)
    //  - джерело (назва модуля програми)
    //  - час події
    //  - текстове повідомлення.
    //Необхідно виводити на друк 10 останніх подій.
    internal class Program
    {
        static void Main(string[] args)
        {
            const int NUMBER_EVENTS_TO_PRINT = 10;
            string fileName = "file.txt";
            int eventNumberToGenerate = 2;
            bool shouldCreateNewFile = false;
            InputOutput.GetUserInput(out fileName, out eventNumberToGenerate, out shouldCreateNewFile);
            try
            {
                // creating an object of the one of the derived classes from EventLog
                EventLog eventLog = EventLogFactory.Create(fileName);
                // generating events
                List<Event> events = EventGenerator.Generate(eventNumberToGenerate);

                // creating new file or updating existing
                if (shouldCreateNewFile)
                    eventLog.CreateEventLog(fileName, events);
                else
                    eventLog.UpdateEventLog(fileName, events);
                List<Event> eventsFromFile = eventLog.Load(fileName);

                //getting last 10 events and printing them to Console
                List<Event> lastEvents = EventProcessor.TakeLastEvents(eventsFromFile, NUMBER_EVENTS_TO_PRINT);
                InputOutput.DisplayEvents(lastEvents);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FileNotFoundException )
            {
                Console.WriteLine($"File {fileName} could not be found");
            }
        }
    }
}