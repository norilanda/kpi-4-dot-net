using laba5.Search;
using laba5.Search.SearchAlgo;
using laba5.Sort;
using laba5.Sort.SortAlgo;
using System.Diagnostics;

namespace laba5
{
    // Розробити модель вибору способів сортування та пошуку максимального / мінімального значення масиву числових об'єктів.
    internal class Program
    {
        static void Main(string[] args)
        {
            int arrSize;
            int sortMethod, searchMethod;
            string messageSort = "Choose sort method ( 0 - Buble Sort, 1 - Merge Sort ): ";
            string messageSearch = "Choose search method ( 0 - Simple Search, 1 - Merge Search ): ";
            double[] arr;
            Sorting sort = new Sorting();
            Searching search = new Searching();
            Stopwatch stopwatch = new Stopwatch();

            arrSize = InputOutput.InputSize();
            arr = ArrayGenerator.Genereate(arrSize, 0, Math.Max(arrSize, 100));
            double[] arrCopy = new double[arr.Length];

            do
            {
                sortMethod = InputOutput.InputMethod(messageSort);
                sort.SetSortingAlgorithm(ChooseSortAlgo.Create(sortMethod));

                Console.WriteLine("Initial array:");
                InputOutput.DisplayArray(arr);

                Array.Copy(arr, arrCopy, arr.Length);
                stopwatch.Restart();
                sort.Sort(arrCopy);
                stopwatch.Stop();

                Console.WriteLine("Sorted array:");
                InputOutput.DisplayArray(arrCopy);
                InputOutput.DisplayTime(stopwatch.Elapsed);
                Console.WriteLine();
            }
            while (InputOutput.ShouldTryAnotherMethod());

            do
            {
                searchMethod = InputOutput.InputMethod(messageSearch);
                search.SetSearchingAlgorithm(ChooseSearchAlgo.Create(searchMethod));

                stopwatch.Restart();
                double? maxNum = search.FindMax(arr);
                double? minNum = search.FindMin(arr);
                stopwatch.Stop();
                InputOutput.DisplayMinMax(min: minNum, max: maxNum);
                InputOutput.DisplayTime(stopwatch.Elapsed);
                Console.WriteLine();
            }
            while (InputOutput.ShouldTryAnotherMethod());
        }
    }
}