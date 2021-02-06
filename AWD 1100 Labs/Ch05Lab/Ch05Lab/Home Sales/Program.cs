using System;
using static System.Console;

/*
 * Write a console application that tracks the home sales of three salespeople (Danielle, Edward, Francis):
        ●	The program prompts the user for a 
            salesperson initial (d, e, or f) and 
            the sales amount, then updates the total sales.
        ●	Any user can have multiple sales.
        ●	If the user enters "z" for the 
            initial then the program 
            should display the total 
            sales for each three salesperson, the grand total  
            for all sales, and the name of the 
            salesperson with the highest total.
        ●	If the user enters an initial other than "d", "e", "f" or "z" 
            then the program should display an error and prompt 
            the user for a new initial.
        ●	All initials should be treated in a case-insensitive manner.

* Program must pass all provided unit tests. (To do so, you will need to follow the format to the right closely.)

* LB7. Implement LB6 as a GUI program.

* Program must pass all provided unit tests.
* 
*/







namespace Home_Sales
{
    class Program
    {
        static void Main(string[] args)
        {
            char initial;
            double amountSale = 0;
            double totalSalesDanielle = 0;
            double totalSalesEdward = 0;
            double totalSalesFrancis = 0;

            while(true)
            {
                Write("Who made the sale? ");
                initial = Convert.ToChar(ReadLine());

                if (initial =='D')
                {
                    Write("How much was the sale? ");
                    amountSale = Convert.ToDouble(ReadLine());
                    totalSalesDanielle = totalSalesDanielle + amountSale;
                }
                else if (initial == 'E')
                {
                    Write("How much was the sale? ");
                    amountSale = Convert.ToDouble(ReadLine());
                    totalSalesEdward = totalSalesEdward + amountSale;
                }
                else if (initial == 'F')
                {
                    Write("How much was the sale? ");
                    amountSale = Convert.ToDouble(ReadLine());
                    totalSalesFrancis = totalSalesFrancis + amountSale;
                }
                else if (initial == 'Z')
                {
                    break;
                }
                else
                {
                    WriteLine("Invalid Initial");
                }
            }

            WriteLine("\n\nDanielle Sales: " + totalSalesDanielle);
            WriteLine("Edward Sales: " + totalSalesEdward);
            WriteLine("Francis Sales: " + totalSalesFrancis);

            double grandTotal = 0;
            grandTotal = totalSalesDanielle + totalSalesEdward + totalSalesFrancis;

            WriteLine("\nGrand Total: " + grandTotal);

            if ((totalSalesDanielle > totalSalesEdward) && (totalSalesDanielle > totalSalesFrancis))
            {
                WriteLine("Danielle has the most sales");
            }
            else if ((totalSalesEdward > totalSalesDanielle) && (totalSalesEdward > totalSalesFrancis))
            {
                WriteLine("Edward has the most sales");
            }
            else
            {
                WriteLine("Francis has the most sales");
            }
        }
    }
}
