using laba5.Sort.SortAlgo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba5.Sort
{
    public class Sorting
    {
        private SortingAlgorithm algorithm;

        public Sorting() { }
        public Sorting(SortingAlgorithm algorithm)
        {
            this.algorithm = algorithm;
        }
        public void SetSortingAlgorithm(SortingAlgorithm algorithm) { this.algorithm = algorithm; }
        public double[]? Sort(double[]? arr)
        {
            return algorithm.Sort(arr);
        }
    }
}
