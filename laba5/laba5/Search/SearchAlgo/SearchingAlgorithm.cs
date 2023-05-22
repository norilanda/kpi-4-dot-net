using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba5.Search.SearchAlgo
{
    public interface SearchingAlgorithm
    {
        public double? FindMin(double[]? arr);
        public double? FindMax(double[]? arr);

    }
}
