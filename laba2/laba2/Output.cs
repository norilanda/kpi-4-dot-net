using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba2
{
    public static class Output
    {
        public static void PrintToConsole(Container container)
        {
            DisplayListOfObjects("Publishers", container.Publishers);
            DisplayListOfObjects("Books", container.Books);
            DisplayListOfObjects("Authors", container.Authors);
            DisplayListOfObjects("Libraries", container.Libraries);
            DisplayListOfObjects("BookOfAuthorList", container.BookOfAuthorList);
            DisplayListOfObjects("BookOfLibraryList", container.BookOfLibraryList);

        }
        public static void DisplayListOfObjects<T>(string listName, List<T> list)
        {
            Console.WriteLine($"{listName}:");
            foreach (var item in list)
                Console.WriteLine($"\t{item}");
        }
        public static void PrintToConsole<T>(IEnumerable<T> collection)
        {
            foreach (var item in collection)
                Console.WriteLine($"\t{item}");
            Console.WriteLine();
        }
        public static void PrintToConsole<T1, T2>(IEnumerable<Tuple<T1, T2>> collection)
        {
            foreach (var item in collection)
                Console.WriteLine($"\t{item.Item1.ToString().PadRight(20)}\t{item.Item2}");
            Console.WriteLine();
        }

        public static void PrintToConsole<TKey, TElement>(IEnumerable<IGrouping<TKey, TElement>> collection)
        {
            foreach (var item in collection)
            {
                Console.WriteLine($"\t{item.Key}");
                foreach (var item1 in item)
                    Console.WriteLine($"\t\t{item1}");
            }
            Console.WriteLine();
        }

        public static void PrintToConsole<T1, T2>(IEnumerable<Tuple<T1, IEnumerable<T2>>> collection)
        {
            foreach (var item in collection)
            {
                Console.WriteLine($"\t{item.Item1}");
                foreach (var item1 in item.Item2)
                    Console.WriteLine($"\t\t{item1}");
            }
            Console.WriteLine();
        }
    }
}
