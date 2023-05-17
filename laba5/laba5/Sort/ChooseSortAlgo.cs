using laba5.Sort.SortAlgo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba5.Sort
{
    public static class ChooseSortAlgo
    {
        public enum SortMehod
        {
            Buble,
            Merge,
        }
        public static SortingAlgorithm Create(SortMehod method)
        {
            switch (method)
            {
                case SortMehod.Buble: return new BubleSort();
                default:
                case SortMehod.Merge: return new MergeSort();
            }
        }
    }
}
