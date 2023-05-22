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
        private SearchingAlgorithm _algorithm;

        public Searching() { }
        
        public Searching(SearchingAlgorithm algorithm) 
        { this._algorithm = algorithm; }

        public void SetSearchingAlgorithm(SearchingAlgorithm algorithm) { this._algorithm = algorithm; }

        public double? FindMin(double[]? arr)
        {
            return _algorithm.FindMin(arr);
        }
        public double? FindMax(double[]? arr)
        {
            return _algorithm.FindMax(arr);
        }

    }
}
