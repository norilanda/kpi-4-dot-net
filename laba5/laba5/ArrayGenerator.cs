using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba5
{
    public static class ArrayGenerator
    {
        public static double[] Genereate(int size, int min = 0, int max = 100)
        {
            double[] arr = new double[size];
            Random rnd = new Random();
            for (int i = 0; i < size; i++)
                arr[i] = rnd.Next(min, max);
            return arr;
        }
    }
}
