//Jacob York
/*Prompt the user to input a word or phrase. Check to see if the word is a Palindrome
(Links to an external site.) or not.Make sure to take case insensitivity into consideration as we do 
not care about capitalization.  For those of you who do not know what a  Palindrome is, it is when you 
spell the word backwards and it is the same word as it was forward.
e.g.mom, civic, radar, level, rotor, kayak, etc…)*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            //define variables
            string userInput, userInputReversed = "";
            int index = 0;

            //input 
            Console.WriteLine("Please enter a word or phrase.");
            userInput = Console.ReadLine().ToLower();
            index = userInput.Length - 1;

            //process
            /*      0   1   2   - counting starts at 0 so index = userInput.Length - 1
             *      M   O   M
             *                  - 3 characters in MOM but last character is 2 in index so 3 - 1 = 2
             */
            while (index >= 0)
            {
                userInputReversed += userInput[index];
                index--;
            }
            if (userInput == userInputReversed)
            {
                Console.WriteLine($"{userInput} is a palindrome.");
            }
            else
            {
                Console.WriteLine($"{userInput} backwards is {userInputReversed} and is not a palindrome.");
            }

            //output
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
