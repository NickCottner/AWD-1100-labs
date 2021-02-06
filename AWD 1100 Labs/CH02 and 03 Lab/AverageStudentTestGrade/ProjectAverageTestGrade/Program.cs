using System;
using static System.Console;
/*
 * 
 * 
 * Write a console program that calculates the average grade for a student
 * 
 * Prompts the use for four test scores
 * Displays the average of the entered test scores
 * 
 * 
 */


namespace ProjectAverageTestGrade
{
    class Program
    {
            //const int MINSCORE =   0;
            //const int MAXSCORE =   100;
        static void Main(string[] args)
        {
            int score1 = 0;
            int score2 = 0;
            int score3 = 0;
            int score4 = 0;
            int pointTot = 0;
            double avg = 0.0;

            Write("\n\n\t\tEnter Test Score 1: ");
            score1 = Convert.ToInt32(ReadLine());

            Write("\n\t\tEnter Test Score 2: ");
            score2 = Convert.ToInt32(ReadLine());

            Write("\n\t\tEnter Test Score 3: ");
            score3 = Convert.ToInt32(ReadLine());

            Write("\n\t\tEnter Test Score 4: ");
            score4 = Convert.ToInt32(ReadLine());

            pointTot = score1 + score2 + score3 + score4;

            avg = pointTot / 4.0;

            WriteLine("\n\n\t\tTest Score 1: " + score1.ToString());
            WriteLine("\n\t\tTest Score 2: " + score2.ToString());
            WriteLine("\n\t\tTest Score 3: " + score3.ToString());
            WriteLine("\n\t\tTest Score 4: " + score4.ToString());
            WriteLine("\n\t\tAverage Test Score: " + avg.ToString());



















        }
    }
}
