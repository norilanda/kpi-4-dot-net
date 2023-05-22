using laba5.Sort.SortAlgo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static laba5.Search.ChooseSearchAlgo;

namespace laba5.Sort
{
    public static class ChooseSortAlgo
    {
        public enum SortMehod
        {
            Buble,
            Merge,
        }
        public static SortingAlgorithm Create(int method)
        {
            if (!Enum.IsDefined(typeof(SortMehod), method))
                return null;
            SortMehod sortMethod = (SortMehod)method;
            switch (sortMethod)
            {
                case SortMehod.Buble: return new BubleSort();
                default:
                case SortMehod.Merge: return new MergeSort();
            }
        }
    }
}
