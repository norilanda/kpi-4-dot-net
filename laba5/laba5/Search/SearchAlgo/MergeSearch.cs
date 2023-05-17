using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba5.Search.SearchAlgo
{
    public class MergeSearch : SearchingAlgorithm
    {
        public override double? FindMax(double[]? arr)
        {
            if (arr == null || arr.Length == 0) return null;
            return MergeSearchRecursion(arr, 0, arr.Length - 1, (num1, num2) => num1 > num2);
        }

        public override double? FindMin(double[]? arr)
        {
            if (arr == null || arr.Length == 0) return null;
            return MergeSearchRecursion(arr, 0, arr.Length - 1, (num1, num2) => num1 < num2);
        }

        protected double MergeSearchRecursion(double[] arr, int start, int end, Func<double, double, bool> compareCondition)
        {
            double numberToSearch = 0;
            if (start == end)
                numberToSearch = arr[start];
            else if(end - start == 1)
            {
                if (compareCondition(arr[start], arr[end]))
                    numberToSearch = arr[start];
                else
                    numberToSearch = arr[end];
            }
            else
            {
                int mid = start + (end - start)/2;
                double leftNumberToSearch = MergeSearchRecursion(arr, start, mid, compareCondition);
                double rightNumberToSearch = MergeSearchRecursion(arr, mid + 1, end, compareCondition);
                if (compareCondition(leftNumberToSearch, rightNumberToSearch))
                    numberToSearch = leftNumberToSearch;
                else
                    numberToSearch = rightNumberToSearch;
            }
            return numberToSearch;
        }
    }
}
