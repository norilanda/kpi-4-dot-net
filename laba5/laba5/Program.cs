using laba5.Search;
using laba5.Search.SearchAlgo;
using laba5.Sort;
using laba5.Sort.SortAlgo;

namespace laba5
{
    // Розробити модель вибору способів сортування та пошуку максимального / мінімального значення масиву числових об'єктів.
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] arr = { 2, 5, 3, 4, 1 };
            Sorting sort = new Sorting(new MergeSort());
            sort.Sort(arr);
            //Searching search = new Searching(new SimpleSearch());
            Searching search = new Searching(new MergeSearch());
            double? maxNum = search.FindMax(arr);
            double? minNum = search.FindMin(arr);
        }
    }
}