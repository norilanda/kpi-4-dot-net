using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba5.Sort.SortAlgo
{
    public class BubleSort : SortingAlgorithm
    {
        public override double[]? Sort(double[]? arr)
        {
            if (arr == null) return arr;
            double temp;
            for (int i = 0; i < arr.Length - 1; i++ )
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }    
                }
            }
            return arr;
        }
    }
}
