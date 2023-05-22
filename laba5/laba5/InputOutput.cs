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

        public static bool ShouldTryAnotherMethod()
        {
            Console.Write("Do u want to try another method for this array? (Y/N): ");
            string? answer = Console.ReadLine();
            while (!IsYesOrNot(answer))
            {
                Console.Write("(Y/N): ");
                answer = Console.ReadLine();
            }
            if (answer.ToLower()[0] == 'y')
                return true;
            return false;
        }

        private static bool IsYesOrNot(string? answer)
        {
            if (answer == null || answer.Length == 0)
                return false;
            answer = answer.Trim().ToLower();
            if (answer[0] != 'y' && answer[0] != 'n')
                return false;
            return true;
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
            Console.WriteLine();
        }
        public static void DisplayMinMax(double? min, double? max)
        {
            Console.WriteLine($"Min: {min}");
            Console.WriteLine($"Max: {max}");
        }

        public static void DisplayTime(TimeSpan ts)
        {
            Console.WriteLine("\tElapsed Time is {0:00}:{1:00}:{2:00}.{3}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds);
        }
    }
}
