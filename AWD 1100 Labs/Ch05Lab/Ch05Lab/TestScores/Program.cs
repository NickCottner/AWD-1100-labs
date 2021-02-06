using System;
using static System.Console;
namespace TestScores
{
    class Program
    {
        const int MINSCORE = 0;
        const int MAXSCORE = 100;

        static void Main(string[] args)
        {
            decimal testScore = 0.0m;
            int numberScore = 0;
            decimal avgScore = 0.0m;
            decimal lowScore = 00.0m;
            decimal highScore = 0.0m;
            decimal totalScore = 0.0m;
            decimal minScore = 0.0m;
            decimal maxScore = 0.0m;


            while (true)
            {
                Write("Please enter a test score: ");
                testScore = Convert.ToInt32(ReadLine());
                if ((testScore >= MINSCORE) && (testScore <= MAXSCORE))
                {
                    numberScore++;
                    totalScore += testScore;
                   
                }
                else if (testScore == 999)
                {
                    break;
                }
                else
                {
                    WriteLine("Invalid score");
                }
            }
            if (lowScore < testScore)
            {
                lowScore = minScore;
            }
            if (highScore > testScore)
            {
                highScore = maxScore;
            }




            avgScore = totalScore / numberScore;

            WriteLine("\n\nNumber of Scores: " + numberScore);
            WriteLine("Sum of test scores: " + totalScore );
            WriteLine("Average test score: " + avgScore);
            WriteLine("Lowest Test Score: " + lowScore);
            WriteLine("Highest Test Score: " + highScore);
            

        }
            
         
            
            
           

           



        }
    }
