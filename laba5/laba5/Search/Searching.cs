using laba5.Search.SearchAlgo;
using laba5.Sort.SortAlgo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba5.Search
{
    public class Searching
    {
        private SearchingAlgorithm algorithm;

        public Searching() { }
        
        public Searching(SearchingAlgorithm algorithm) 
        { this.algorithm = algorithm; }

        public void SetSearchingAlgorithm(SearchingAlgorithm algorithm) { this.algorithm = algorithm; }

        public double? FindMin(double[]? arr)
        {
            return algorithm.FindMin(arr);
        }
        public double? FindMax(double[]? arr)
        {
            return algorithm.FindMax(arr);
        }

    }
}
