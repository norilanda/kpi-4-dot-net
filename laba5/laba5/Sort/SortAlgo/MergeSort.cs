using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba5.Sort.SortAlgo
{
    public class MergeSort : SortingAlgorithm
    {
        public override double[]? Sort(double[]? arr)
        {
            if (arr == null) return arr;
            MergeSortRecursion(arr, 0, arr.Length-1);
            return arr;
        }
        private void MergeSortRecursion(double[] arr, int start, int end)
        {
            if (start < end)
            {
                int mid = start + (end - start)/2;
                MergeSortRecursion(arr, start, mid);
                MergeSortRecursion(arr, mid + 1, end);
                Merge(arr, start, mid, end);
            }
        }

        private void Merge(double[] arr, int start, int mid, int end)
        {
            int lenLeft = mid - start + 1;
            int lenRight = end - mid;

            double[] arrLeft = new double[lenLeft];
            double[] arrRight = new double[lenRight];

            int i, j, k;
            k = start;

            for (i=0; i<lenLeft; i++)
                arrLeft[i] = arr[start + i];
            for (j = 0; j < lenRight; j++)
                arrRight[j] = arr[mid + 1 + j];

            i = 0;
            j = 0;

            while (i < lenLeft && j < lenRight)
            {
                if (arrLeft[i] <= arrRight[j])
                {
                    arr[k] = arrLeft[i];
                    i++;
                }
                else
                {
                    arr[k] = arrRight[j];
                    j++;
                }
                k++;
            }

            while (i < lenLeft)
            {
                arr[k] = arrLeft[i];
                i++;
                k++;
            }

            while (j < lenRight)
            {
                arr[k] = arrRight[j];
                j++;
                k++;
            }
        }

    }
}
