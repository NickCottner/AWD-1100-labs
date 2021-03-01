using System;
using static System.Console;

namespace ArrayConsoleModularized
{
    class Program
    {
        const int MAX = 25;

        static int[] numbers = new int[MAX];
        static int sum = 0;
        static void Main(string[] args)
        {
            fillNumbersArray();
            sortNumbersArrayAscending();
            findSmallestNumbersArrayElement();
            sortNumbersArrayDescending();
            findLargestNumbersArrayElement();
            findSumNumbersArray();
            findAvgNumbersArray();
        }
        static void fillNumbersArray()
        {
            string outStr = "";

            Random rand = new Random();

            for (int lcv = 0; lcv < numbers.Length; ++lcv)
            {
                numbers[lcv] = rand.Next(1, 100);
            }
            for (int lcv = 0; lcv < numbers.Length; ++lcv)
            {
                outStr += numbers[lcv] + " ";
            }
            WriteLine("\n\nArray in Original Order\n" + outStr);
        }
        static void sortNumbersArrayAscending()
        {
            string outStr = " ";
            Array.Sort(numbers);

            outStr = " ";
            for (int lcv = 0; lcv < numbers.Length; ++lcv)
            {
                outStr += numbers[lcv] + " ";
            }
            WriteLine("\n\nArray in Ascending Order\n" + outStr);
        }
        static void findSmallestNumbersArrayElement()
        {
            WriteLine("\n\nThe Smallest Array Element is: " + numbers[0].ToString());
        }
        static void sortNumbersArrayDescending()
        {
            string outStr = " ";

            Array.Reverse(numbers);

            outStr = " ";
            for(int lcv = 0; lcv < numbers.Length; ++lcv)
            {
                outStr += numbers[lcv] + " ";
            }
            WriteLine("\n\nArray in Descending order\n" + outStr);
        }
        static void findLargestNumbersArrayElement()
        {
            WriteLine("\n\nThe Largest Array Element is: " + numbers[0].ToString());
        }
        static void findSumNumbersArray()
        {
            int sum = 0;

            for(int lcv = 0; lcv < numbers.Length; ++lcv)
            {
                sum += numbers[lcv];
            }
            WriteLine("\n\n The Sum of All Array Elements is: " + sum.ToString());
        }
        static void findAvgNumbersArray()
        {
            int sum = 0;

            double avg = (double)sum / numbers.Length;
            WriteLine("\n\nThe Average of All Array Elements is: " + avg.ToString("f2"));
        }
    }
}
