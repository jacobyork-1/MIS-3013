//Jacob York
/*Prompt the user to input the name of the month. Using the table below, 
determine how many days there are in the month.  If the user enters February, 
you will need to ask them a follow-up question to determine whether or not it is a Leap Year or not 
(leap years have 29 days, where as non leap years have 28)*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysInTheMonth
{
    class Program
    {
        static void Main(string[] args)
        {
            //define variables
            string monthName;
            int daysInMonth = 0;

            //input 
            Console.WriteLine("Please nput name of the month.");
            monthName = Console.ReadLine().ToLower();

            //process
            if (monthName == "january" || monthName == "march" || monthName == "may" || monthName == "july" || monthName == "august" || monthName == "october" || monthName == "december")
            {
                daysInMonth = 31;
            }
            else if (monthName == "february")
            {
                Console.WriteLine("Is it a leap year? yes or no");
                string userInput = Console.ReadLine();
                if (userInput == "yes")
                {
                    daysInMonth = 29;
                }
                else
                {
                    daysInMonth = 28;
                }
            }
            else if (monthName == "april" || monthName == "june" || monthName == "september" || monthName == "november")
            {
                daysInMonth = 30;
            }
            //output
            Console.WriteLine($"The month of {monthName} has {daysInMonth} days.");
            Console.ReadLine();
        }
    }
}
