//Jacob York
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developer_Information
{
    class Program
    {
        static void Main(string[] args)
        {
            string calculationType;
            string answer;
            List<double> calculation = new List<double>();
            double val1 = 1;
            double val2 = 1;

            do
            {
                Console.WriteLine("What type of calculation would you like to perform? (i.e. add, subtract, multiply, divide)");
                calculationType = Console.ReadLine().ToLower();

                Console.WriteLine("Please enter your first value.");
                val1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Please enter your second value.");
                val2 = Convert.ToDouble(Console.ReadLine());

                if (calculationType == "add")
                {
                    Console.WriteLine($"{val1} + {val2} = {add(val1, val2)}");
                }
                else if (calculationType == "subtract")
                {
                    Console.WriteLine($"{val1} - {val2} = {subtract(val1, val2)}");
                }
                else if (calculationType == "multiply")
                {
                    Console.WriteLine($"{val1} * {val2} = {multiply(val1, val2)}");
                }
                else if (calculationType == "divide")
                {
                    Console.WriteLine($"{val1} / {val2} = {divide(val1, val2)}");
                }



                Console.WriteLine("Would you like to perform a new calculation? yes or no");
                string input1 = Console.ReadLine();
                while (input1 != "yes")
                {
                    Console.WriteLine("What type of calculation would you like to perform? (i.e. add, subtract, multiply, divide)");
                    calculationType = Console.ReadLine().ToLower();

                    Console.WriteLine("Please enter your first value.");
                    val1 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Please enter your second value.");
                    val2 = Convert.ToDouble(Console.ReadLine());

                    if (calculationType == "add")
                    {
                        Console.WriteLine($"{val1} + {val2} = {add(val1, val2)}");
                    }
                    else if (calculationType == "subtract")
                    {
                        Console.WriteLine($"{val1} - {val2} = {subtract(val1, val2)}");
                    }
                    else if (calculationType == "multiply")
                    {
                        Console.WriteLine($"{val1} * {val2} = {multiply(val1, val2)}");
                    }
                    else if (calculationType == "divide")
                    {
                        Console.WriteLine($"{val1} / {val2} = {divide(val1, val2)}");
                    }
                }

                Console.WriteLine("Would you like to reuse your previous values?");
                string input2 = Console.ReadLine();
                while (input2 == "yes")
                {

                }

                Console.WriteLine("Are you finished with the application? yes or no");
                string input3 = Console.ReadLine().ToLower();
                Console.WriteLine("Thank you for using this service.");
                answer = Console.ReadLine().ToLower();
            } while (answer != "no");

        }

        static double divide(double val1, double val2)
        {
            return val1 / val2;
        }

        static double multiply(double val1, double val2)
        {
            return val1 * val2;
        }

        static double subtract(double val1, double val2)
        {
            return val1 - val2;
        }

        static double add(double val1, double val2)
        {
            return val1 + val2;
        }
        static void DeveloperInformation(string developerName, string className, string dateOfWriting)
        {
            Console.WriteLine($"{developerName} wrote this application for {className} on {dateOfWriting}.");
        }
    }
}
