using laba5.Search.SearchAlgo;
using laba5.Sort;
using laba5.Sort.SortAlgo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static laba5.Search.ChooseSearchAlgo;

namespace laba5.Search
{
    public static class ChooseSearchAlgo
    {
        public enum SearchMehod
        {
            Simple,
            Merge,
        }
        public static SearchingAlgorithm Create(int method)
        {
            if (!Enum.IsDefined(typeof(SearchMehod), method))
                return null;
            SearchMehod searchMethod = (SearchMehod)method;
            switch (searchMethod)
            {
                case SearchMehod.Simple: return new SimpleSearch();
                default:
                case SearchMehod.Merge: return new MergeSearch();
            }
        }
    }
}
