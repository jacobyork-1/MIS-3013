//Jacob York
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_MIN_MAX_AVG
{
    class Program
    {
        static void Main(string[] args)
        {
            string examScore, answer;
            List<double> scores = new List<double>();

            do
            {
                Console.WriteLine($"Please enter your exam score.");
                examScore = Console.ReadLine();
                double es = Convert.ToDouble(examScore);
                scores.Add(es);
                //scores.Add(Convert.ToDouble(Console.ReadLine()));

                Console.WriteLine("Do you want to input another exam score? yes or no");
                answer = Console.ReadLine();
            } while (answer.ToLower() == "yes");

            double sum = 0; //this is often referred to as an accumulator variable
            double minimum = 100;
            double maximum = -1;
            for (int i = 0; i < scores.Count; i++)
            {
                double score = scores[i];
                sum += score;

                if (score < minimum)
                {
                    minimum = score;
                }
                if (score > maximum)
                {
                    maximum = score;
                }
            }

            foreach (var score in scores)
            {
                sum += score;

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
            Console.WriteLine($"Your minimum exam score is {minimum.ToString("N3")}");
            Console.WriteLine($"Your minimum exam score is {maximum.ToString("N3")}");

            Console.ReadKey();
        }
    }
}
