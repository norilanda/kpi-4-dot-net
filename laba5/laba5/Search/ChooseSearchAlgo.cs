using laba5.Search.SearchAlgo;
using laba5.Sort.SortAlgo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba5.Search
{
    public static class ChooseSearchAlgo
    {
        public enum SearchMehod
        {
            Simple,
            Merge,
        }
        public static SearchingAlgorithm Create(SearchMehod method)
        {
            switch (method)
            {
                case SearchMehod.Simple: return new SimpleSearch();
                default:
                case SearchMehod.Merge: return new MergeSearch();
            }
        }
    }
}
