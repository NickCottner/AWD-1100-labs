using System;
using static System.Console;
/*
 * 
 * Pig Latin is a nonsense language. To create
 * a work in Pig Latin, you remove the first letter
 * and then add the first letter and "ay" at the
 * end of the word.
 * 
 * For example, "dog" becomes "ogday" and "cat"
 * becomes "atcay."
 * 
 * Write a console program that allows the user
 * to enter a word and displays the Pig Latin version.
 *
 * Hint: Research and use String.Substring()
 * 
 * 
 */


namespace ProjectPigLatin
{
    class Program
    {
        static void Main(string[] args)
        {
            const string SUFFIX = "ay";

            string word = "";
            char firstChar = ' ';

            Write("Enter any English Word: ");
            word = ReadLine();
            //firstChar = word[0];
            firstChar = Convert.ToChar(word.Substring(0, 1));
            word = word.Remove(0, 1);
            WriteLine("The first letter is: " + firstChar);
            WriteLine("The remaining string is: " + word);
            word = word + firstChar.ToString() + SUFFIX;
            WriteLine("The Pig Latin String is: " + word);

        }
    }
}
