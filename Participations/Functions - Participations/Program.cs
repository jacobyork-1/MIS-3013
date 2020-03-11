using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions___Participations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What participation would you like to run? \n 1) Coin Toss \n 2) Collections MIN MAX AVG \n 3) Run All");
            string userInput = Console.ReadLine().ToLower();
            if (userInput == "coin toss")
            {
                coinToss();
            }
            else if (userInput == "collections MIN MAX AVG")
            {
                collectionsMINMAXAVG();
            }
            else if (userInput == "run all")
            {
                coinToss();
                collectionsMINMAXAVG();
            }


            Console.ReadLine();
        }
        static void coinToss()
        {
            Random rand = new Random();
        //use the next method on 'rand' and pass in 0,2 to generate a random number that is 0 or 1
        int randomNumber = rand.Next(0, 2);
        Console.WriteLine(randomNumber);
            Console.WriteLine("Enter Heads or Tails >>");
            string usersGuessAsString = Console.ReadLine();
        int usersGuess;
        const int HEADS_VALUE = 0;
        const int TAILS_VALUE = 1;

            if (usersGuessAsString == "Heads")
            {
                usersGuess = HEADS_VALUE;
            }
            else if (usersGuessAsString == "Tails")
            {
                usersGuess = TAILS_VALUE;
            }
            else
            {
                Console.WriteLine("Invalid entry: Please try again later");
                Console.ReadKey();
                return;
            }



            if (usersGuess == randomNumber)
            {
                Console.WriteLine($"Congrats, {usersGuessAsString} was right!");
            }
            else
            {
                if (usersGuess == 0)
                {
                    Console.WriteLine($"Sorry, Tails was the correct answer and you guessed {usersGuessAsString}  =(");
                    //"Sorry, Tails was the correct answer and you guessed " + usersGuessAsString + "  =(");
                }
                else
                {
                    Console.WriteLine($"Sorry, Heads was the correct answer and you guessed {usersGuessAsString}  =(");
                }
            }

            Console.ReadKey(); //Prevent the application from closing until we press a key
        }

        static void collectionsMINMAXAVG()
        {
            string examScore, answer;
            List<double> scores = new List<double>();

            do
            {
                Console.WriteLine($"Please enter your exam score >>");
                examScore = Console.ReadLine();
                double es = Convert.ToDouble(examScore);
                scores.Add(es);
                //scores.Add(Convert.ToDouble(Console.ReadLine()));

                Console.WriteLine("Do you want to input another exam score? yes/no >>");
                answer = Console.ReadLine();
            } while (answer.ToLower() == "yes");

            double sum = 0; // this is often referred to as an ACCUMULATOR variable
            double minimum = scores[0];
            double maximum = scores[0];
            //for (int i = 0; i < scores.Count; i++)
            //{
            //    double score = scores[i];
            //    sum = sum + score;

            //    if (score < minimum)
            //    {
            //        minimum = score;
            //    }

            //    if (score > maximum)
            //    {
            //        maximum = score;
            //    }

            //}

            foreach (var score in scores)
            {
                sum = sum + score;

                if (score < minimum)
                {
                    minimum = score;
                }

                if (score > maximum)
                {
                    maximum = score;
                }
            }

            double average = sum / scores.Count;

            Console.WriteLine($"Your average for the {scores.Count} exam grades is {average.ToString("N3")}.");
            Console.WriteLine($"Your minimum exam score is {minimum.ToString("N3")}.");
            Console.WriteLine($"Your maximum exam score is {maximum.ToString("N3")}.");

            Console.ReadKey();
        }
    }
}
