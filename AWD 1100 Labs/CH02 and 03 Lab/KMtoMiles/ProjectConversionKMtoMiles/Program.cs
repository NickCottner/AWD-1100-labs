using System;
using static System.Console;
/*
 * 
 * 
 * 
 * Write a console program that converts distances from miles to kilometers:
 * 
 * 
 * Declares a named constant named km_per_mile which holds the number of kilometers in a mile (1.6 km per mile).
 * Prompts the user for a distance in miles.
 * Displays the distance in both kilometers and miles.
 * For example: 3.0 miles is 4.8 kilometers
 * 
 * 
 * 
 */

namespace ProjectConversionKMtoMiles
{
    class Program
    {
        static void Main(string[] args)
        {
            const double km_per_mile = 1.6;
            double miles = 0.0;
            double kilos = 0.0;

            WriteLine("Enter value representing miles: ");
            miles = Convert.ToDouble(ReadLine());
            kilos = miles * km_per_mile;

            WriteLine(miles.ToString("f1") + " miles = " +
                kilos.ToString("f1") + " kilometers");
           





            
            
            


        }
    }
}
