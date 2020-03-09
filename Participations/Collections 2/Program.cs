//Jacob York
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] courseSubject = new string[3];
            double[] courseNumbers = new double[3];
            string examScore, answer;
            List<double> scores = new List<double>();


            for (int name = 0; name < courseSubject.Length; name++)
            {
                Console.WriteLine("Please enter course subject name.");
                courseSubject[name] = Console.ReadLine();
            }

            for (int number = 0; number < courseNumbers.Length; number++)
            {
                Console.WriteLine("Please enter course number.");
                courseNumbers[number] = Convert.ToDouble(Console.ReadLine());
            }

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"{courseSubject[i]} { courseNumbers[i]}");
            }

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

            double sum = 0;
            foreach (var score in scores)
            {
                sum += score;
            }

            double average = sum / scores.Count;

            Console.WriteLine($"Your average exam score is {average.ToString("N2")}.");
            Console.ReadKey();
        }
    }
}
