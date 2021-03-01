using System;
using static System.Console;

namespace ArrayConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            const int MAX = 25; // Number of Array Elements

            int[] numbers = new int[MAX];
            int smallest = 101;
            int largest = 0;
            int sum = 0;
            double average = 0.0;
            string outStr = "";

            Random rand = new Random();

            for (int lcv = 0; lcv < numbers.Length; ++lcv)
            {
                numbers[lcv] = rand.Next(1, 100);
            }

            for (int lcv = 0; lcv < numbers.Length; ++lcv) // print out array in its original order
            {
                outStr += numbers[lcv] + " ";
            }
            WriteLine("\n\nArray in original order\n" + outStr);

            //Sort the array in ascending order
            Array.Sort(numbers);

            outStr = "";
            for (int lcv = 0; lcv < numbers.Length; ++lcv) // print out array in its ascending order
            {
                outStr += numbers[lcv] + " ";
            }
            WriteLine("\n\nArray in ascending order\n" + outStr);


            //Sort the array in desecnding order
            Array.Reverse(numbers);

            outStr = "";
            for (int lcv = 0; lcv < numbers.Length; ++lcv) // print out array in its descending order
            {
                outStr += numbers[lcv] + " ";
            }
            WriteLine("\n\nArray in descending order\n" + outStr);

            //Sort the array in desecnding order
            Array.Reverse(numbers);

            outStr = "";
            for (int lcv = 0; lcv < numbers.Length; ++lcv) // print out array in smallest way
            {
                if (numbers[lcv] < smallest) 
                {
                    smallest = numbers[lcv];
                }
            }
            WriteLine("\n\nThe smallest array element: " + smallest.ToString());

            outStr = "";
            for (int lcv = 0; lcv  < numbers.Length; ++lcv) // print out array in largest way
            {
                if (numbers[lcv] > largest)
                {
                    largest = numbers[lcv];
                }
            }
            WriteLine("\n\nThe largest array element: " + largest.ToString());

            outStr = "";
            for (int lcv = 0; lcv < numbers.Length; ++lcv) // print out sum of arrays 
            {
                sum += numbers[lcv];
            }
            WriteLine("\n\nThe sum of all array element: " + sum);

            outStr = "";
            for (int lcv = 0; lcv < numbers.Length; ++lcv) // print out sum of arrays 
            {
                average = (double)sum / numbers.Length;
            }
            WriteLine("\n\nThe average of all array element: " + average.ToString("f2"));
        }
    }
}
