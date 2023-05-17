using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba5
{
    public static class InputOutput
    {
        public static int InputSize()
        {
            int size = 0;
            Console.Write("Enter array size: ");  
            while (!int.TryParse(Console.ReadLine(), out size) || size < 1)
            {
                Console.Write("Array size should be a number > 1! Try again: ");
            }
            return size;
        }

        public static int InputMethod(string message, int numberOfFirstMethod = 0, int numberOfLastMethod = 1)
        {
            int method = -1;
            Console.Write(message);
            while (!int.TryParse(Console.ReadLine(), out method) || method < numberOfFirstMethod || method > numberOfLastMethod)
            {
                Console.WriteLine("Input correct method! ");
            }
            return method;
        }
        public static void DisplayArray(double[] arr)
        {
            const int MAX_ARR_SIZE_TO_DISPLAY = 50;
            const int ELEMENT_NUMBER_IN_CHUNK = 25;
            Console.Write("\t");
            if (arr.Length > MAX_ARR_SIZE_TO_DISPLAY)
            {
                for (int i = 0; i < ELEMENT_NUMBER_IN_CHUNK; i++)
                    Console.Write(arr[i] + " ");
                Console.Write(" ... ");
                for (int i = arr.Length - ELEMENT_NUMBER_IN_CHUNK - 1; i < arr.Length; i++)
                    Console.Write(arr[i] + " ");
            }
            else
            {
                for (int i = 0; i < arr.Length; i++)
                    Console.Write(arr[i] + " ");
            }
            Console.WriteLine("\n");
        }
        public static void DisplayMinMax(double? min, double? max)
        {
            Console.WriteLine($"Min: {min}");
            Console.WriteLine($"Max: {max}");
        }
    }
}
