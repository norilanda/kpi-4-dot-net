using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba3
{
    public static class InputOutput
    {
        public static void DisplayEvents(List<Event> events)
        {
            Console.WriteLine("N  LEVEL\t SOURCE \tTIME\n=======================================================");
            for (int i = 0; i < events.Count(); i++)
            {
                Console.Write($"{i+1}. ");
                Console.WriteLine(events[i]);
                Console.WriteLine();
            }
        }
        public static void GetUserInput(out string fileName, out int eventNumberToGenerate, out bool shouldCreateNewFile)
        {
            Console.WriteLine("Enter file name with extension (Ex.: file.txt)");
            fileName = Console.ReadLine();
            while (Path.GetExtension(fileName) == String.Empty)
            {
                Console.WriteLine("Your file should have an extension specified! Try again!");
                fileName = Console.ReadLine();
            }

            Console.WriteLine("Enter number of events to generate (Ex.: 3)");
            eventNumberToGenerate = -1;
            while (!int.TryParse(Console.ReadLine(), out eventNumberToGenerate) || eventNumberToGenerate <= 0) 
            {
                Console.WriteLine("Please, enter correct positive number!");
            }

            Console.Write("Should the new log file be created or use existing one? n - new, e - existing: ");
            string newOrExisting = Console.ReadLine().ToLower().TrimStart();
            while (newOrExisting.Length == 0 || (newOrExisting[0] != 'n' && newOrExisting[0] != 'e'))
            {
                Console.WriteLine("Type 'n' or 'e'!");
                newOrExisting = Console.ReadLine().ToLower().TrimStart(); 
            }
            if (newOrExisting[0] == 'n')
                shouldCreateNewFile = true;
            else
                shouldCreateNewFile = false;
        }
    }
}
