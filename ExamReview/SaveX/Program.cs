//Jacob York
/*Write an application that will prompt the user how much money they will save a week, 
 * how much interest rate they get per month(if they are just keeping their money in a jar underneath the bed, they can input 0),  
 * and for how many years they would like to save for.  Assume that there are always 4 weeks in a month and that there are always 12 months in a year;)
Output the total amount saved after each month with the month and year in the output:
e.g.January, year 1: Money saved so far is $380.83*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveX
{
    class Program
    {
        static void Main(string[] args)
        {
            //define variables
            double savings = 0;
            double interestRate = 0.0;
            int years = 0;
            double totalAmountSaved = 0;
            int numYears = 1;
            int numMonths = 1;

            //input
            Console.WriteLine("How much money do you plan to save per week?");
            savings = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is the per month interest rate?");
            interestRate = Convert.ToDouble(Console.ReadLine()) / 100;

            Console.WriteLine("How many years will you be saving for?");
            years = Convert.ToInt32(Console.ReadLine());

            //process
            for (int month = 1; month <= years * 12; month++)
            {
                totalAmountSaved += savings * 4;
                totalAmountSaved += totalAmountSaved * interestRate;

                string monthsName = month.ToString("N0");

                if (numMonths == 1)
                {
                    monthsName = "January";
                }
                else if (numMonths == 2)
                {
                    monthsName = "February";
                }
                else if (numMonths == 3)
                {
                    monthsName = "March";
                }
                else if (numMonths == 4)
                {
                    monthsName = "April";
                }
                else if (numMonths == 5)
                {
                    monthsName = "May";
                }
                else if (numMonths == 6)
                {
                    monthsName = "June";
                }
                else if (numMonths == 7)
                {
                    monthsName = "July";
                }
                else if (numMonths == 8)
                {
                    monthsName = "August";
                }
                else if (numMonths == 9)
                {
                    monthsName = "September";
                }
                else if (numMonths == 10)
                {
                    monthsName = "October";
                }
                else if (numMonths == 11)
                {
                    monthsName = "November";
                }
                else if (numMonths == 12)
                {
                    monthsName = "December";
                }

                Console.WriteLine($"{monthsName}, year {numYears.ToString("N0")}: Money saved so far is {totalAmountSaved.ToString("C2")}");

                if (month % 12 == 0)
                {
                    numYears++;
                    numMonths = 1;
                }
                numMonths++;
            }

            //output
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
