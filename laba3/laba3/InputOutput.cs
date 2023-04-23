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
    }
}
