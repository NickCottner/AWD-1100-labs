using System;
using static System.Console;
using System.Collections;

namespace ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            const int LEN = 25;

            ArrayList numbers = new ArrayList(LEN);

            int sum = 0;
            double avg = 0.0;

            Random rand = new Random();

            for(int lcv = 0; lcv < numbers.Count; ++lcv)
            {
                numbers.Add(rand.Next(1, 100));
            }

            WriteLine("The ArrayList In Original Order:\n");
            printArrayList(numbers);


            numbers.Sort();
            WriteLine("The ArrayList in Ascending Order:\n");
            printArrayList(numbers);

            numbers.Reverse();
            WriteLine("The ArrayList in Descending Order:\n");
            printArrayList(numbers);

            foreach(int number in numbers)
            {
                sum += number
            }
            WriteLine("The ArrayList Sum Is:\n" + sum);

            avg = (double)sum / numbers.Count;
            WriteLine("The ArrayList Average Is: " + avg.ToString("f2"))
        }


        static void printArrayList(ArrayList numbers)
        {
            string outStr = "";

            foreach (int number in numbers)
            {
                outStr += number + " ";
            }

            WriteLine(outStr);
        }
    }
}
