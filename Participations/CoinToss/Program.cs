//Jacob York
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinToss
{
    class Program
    {
        static void Main(string[] args)
        {

            //Initiate Heads or Tails to user
            Console.WriteLine("Heads or Tails?");
            string userGuessAsString = Console.ReadLine();
            int userGuess;
            //Heads Function
            if (userGuessAsString == "Heads")
            {
                userGuess = 0;
            }
            else
            {
                userGuess = 1;
            }

            //Tails Function
            if (userGuessAsString == "Tails")
            {
                userGuess = 1;
            }
            else
            {
                userGuess = 0;
            }

            Random rand = new Random();
            //use the next method on 'rand' and pass in 0,2 to generate a random number that is 0 or 1 | (MINIMUM, MAXIMUM) = (0, 2) 0 is included and 2 is excluded
            int randomNumber = rand.Next(0, 2);
            //Heads Function
            if (randomNumber == 0)
            {
                Console.WriteLine("The coin landed on Heads.");
            }
            //Tails Function
            else
            {
                Console.WriteLine("The coin landed on Tails.");
            }
            if (randomNumber == userGuess)
            {
                Console.WriteLine("You Win.");
            }
            else
            {
                Console.WriteLine("You Lose.");
            }
            Console.ReadKey();

        }
    }
}
