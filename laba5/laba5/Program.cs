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
            int arrSize = 100;
            int sortMethod, searchMethod;
            string messageSort = "Choose sort method ( 0 - Buble Sort, 1 - Merge Sort ): ";
            string messageSearch = "Choose search method ( 0 - Simple Search, 1 - Merge Search ):";
            //arrSize = InputOutput.InputSize();
            double[] arr = { 2, 5, 3, 4, 1 };
            arr = ArrayGenerator.Genereate(arrSize);

            sortMethod = 0;
            //sortMethod = InputOutput.InputMethod(messageSort);

            Sorting sort = new Sorting(ChooseSortAlgo.Create((ChooseSortAlgo.SortMehod)sortMethod));
            Console.WriteLine("Initial array:");
            InputOutput.DisplayArray(arr);
            sort.Sort(arr);
            Console.WriteLine("Sorted array:");
            InputOutput.DisplayArray(arr);

            searchMethod = 0;
            //sortMethod = InputOutput.InputMethod(messageSearch);

            Searching search = new Searching(ChooseSearchAlgo.Create((ChooseSearchAlgo.SearchMehod)searchMethod));
            double? maxNum = search.FindMax(arr);
            double? minNum = search.FindMin(arr);
            InputOutput.DisplayMinMax(maxNum, minNum);
        }
    }
}