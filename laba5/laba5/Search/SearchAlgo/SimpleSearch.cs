using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba5.Search.SearchAlgo
{
    public class SimpleSearch : SearchingAlgorithm
    {
        public double? FindMax(double[]? arr)
        {
            return FindByCompareCondition(arr, (maxNum, currentNum) => maxNum < currentNum);
        }

        public double? FindMin(double[]? arr)
        {
            return FindByCompareCondition(arr, (minNum, currentNum) => minNum > currentNum);
        }

        private double? FindByCompareCondition(double[]? arr, Func<double, double, bool> compareCondition)
        {
            if (arr == null || arr.Length == 0) return null;
            double numberToSearch = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (compareCondition(numberToSearch, arr[i]))
                    numberToSearch = arr[i];
            }
            return numberToSearch;
        }
    }
}
