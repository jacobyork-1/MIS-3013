//Jacob York
/*Write an application that will output all of the numbers from 1 to 100 added together as well 
 * as output all of the numbers from 1 to 100 multiplied together.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1to100
{
    class Program
    {
        static void Main(string[] args)
        {
            //define variables
            int counter;
            int sum = 0;
            double multi = 1;

            //process 
            for (counter = 1; counter <= 100; counter++)
            {
                sum += counter;
                multi *= counter;
            }

            //output
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
            }
    }
}
