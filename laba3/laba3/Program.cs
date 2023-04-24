using laba3.EventLogs;
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
            string fileName = "file.txt";
            int eventNumberToGenerate = 2;
            bool shouldCreateNewFile = false;
            InputOutput.GetUserInput(out fileName, out eventNumberToGenerate, out shouldCreateNewFile);
            try
            {
                EventLog eventLog = EventLogFactory.Create(fileName);
                List<Event> events = EventGenerator.Generate(eventNumberToGenerate);

                if (shouldCreateNewFile)
                    eventLog.CreateEventLog(fileName, events);
                else
                    eventLog.UpdateEventLog(fileName, events);
                List<Event> eventsFromFile = eventLog.Load(fileName);

                InputOutput.DisplayEvents(eventsFromFile);
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