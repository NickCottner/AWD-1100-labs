using System;
using static System.Console;
/*
 * 
 * 
 * Write a console program that calculates 
 * projected raises:
 * 
 *      Declares a named constant Percent_Raise
 *      and assign it a value of 4% (or 0.04)
 *      
 *      Prompts the user for names and salaries of three employees.
 *      
 *      Displays the projected salaries for these three employees over
 *      the next 2 years in a table, assuming that they get a 4% raise
 *      every year.
 *     
 *     
 *     +------------+------------+------------+------------+
 *     |Year        |Bob         |Fred        |Will        |
 *     +------------+------------+------------+------------+
 *     |2018        |$10,000.00  |$20,000.00  |$30,000.00  |
 *     |2019        |$10,400.00  |$20,800.00  |$31,200.00  |
 *     |2020        |$10,816.00  |$21,632.00  |$32.440.00  |
 *     +------------+------------+------------+------------+
 *    
 */

namespace ProjectPercentRaises
{
    class Program
    {
        static void Main(string[] args)
        {
            const double Percent_Raise = 0.04;

            String e1Name = "";
            String e2Name = "";
            String e3Name = "";
            double e1Yr1 = 0.0;
            double e1Yr2 = 0.0;
            double e1Yr3 = 0.0;
            double e2Yr1 = 0.0;
            double e2Yr2 = 0.0;
            double e2Yr3 = 0.0;
            double e3Yr1 = 0.0;
            double e3Yr2 = 0.0;
            double e3Yr3 = 0.0;

            WriteLine("\n\n");
            Write("\t\tInput employee1 name: ");
            e1Name = ReadLine();
            Write("\t\tInput employee1 salary: ");
            e1Yr1 = Convert.ToDouble(ReadLine());
            e1Yr2 = e1Yr1 + (e1Yr1 * Percent_Raise);
            e1Yr3 = e1Yr2 + (e1Yr2 * Percent_Raise);

            WriteLine("\n");
            Write("\t\tInput employee2 name: ");
            e2Name = ReadLine();
            Write("\t\tInput employee2 salary: ");
            e2Yr1 = Convert.ToDouble(ReadLine());
            e2Yr2 = e2Yr1 + (e2Yr1 * Percent_Raise);
            e2Yr3 = e2Yr2 + (e2Yr2 * Percent_Raise);

            WriteLine("\n");
            Write("\t\tInput employee3 name: ");
            e3Name = ReadLine();
            Write("\t\tInput employee3 salary: ");
            e3Yr1 = Convert.ToDouble(ReadLine());
            e3Yr2 = e3Yr1 + (e3Yr1 * Percent_Raise);
            e3Yr3 = e3Yr2 + (e3Yr2 * Percent_Raise);

            WriteLine("\n\n");
            WriteLine("\t\t+------------+------------+------------+----------------+");
            WriteLine("\t\t| Year\t| " + e1Name + "\t      | " + e2Name + "\t   | " + e3Name + "\t        |");
            WriteLine("\t\t| 2018\t| " + e1Yr1.ToString("c") + "  | " + e2Yr1.ToString("c") + " | " + e3Yr1.ToString("c") + "         |");
            WriteLine("\t\t| 2019\t| " + e1Yr2.ToString("c") + "  | " + e2Yr2.ToString("c") + " | " + e3Yr2.ToString("c") + "         |");
            WriteLine("\t\t| 2020\t| " + e1Yr3.ToString("c") + "  | " + e2Yr3.ToString("c") + " | " + e3Yr3.ToString("c") + "         |");
            WriteLine("\t\t+------------+------------+------------+----------------+");



        }
    }
}
 