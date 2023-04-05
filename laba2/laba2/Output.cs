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
        public static void DisplayToConsole(Container container)
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
    }
}
