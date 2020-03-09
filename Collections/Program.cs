//Jacob York
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer;
            List<double> examGrades = new List<double>();
            List<double> quizGrades = new List<double>();
            List<double> homeworkGrades = new List<double>();

            do
            {
                double grade = getValidDoubleFromUser("Please enter your exam grade");
                examGrades.Add(grade);

                double grade = getValidDoubleFromUser("Please enter your exam grade");
                quizGrades.Add(grade);

                double grade = getValidDoubleFromUser("Please enter your exam grade");
                homeworkGrades.Add(grade);

                Console.WriteLine("Do you have another value to enter?");
                answer = Console.ReadLine();
            } while (answer.ToLower() != "no");

            int sum = Add(5, 5);
            int firstNum = 3;
            int secondNum = 4;
            double difference = Subtract(firstNum, secondNum);
        }

        private static double Subtract(int first, int second)
        {
            return first - second;
        }

        private static int Add(int v1, int v2)
        {
            return v1 + v2;
        }

        static double getValidDoubleFromUser(string message)
        {
            Console.WriteLine(message);
            string response = Console.ReadLine();
            double grade;

            while (double.TryParse(response, out grade) != true)
            {
                Console.WriteLine("Sorry, you must enter a valid number, please try again.");
                response = Console.ReadLine();
            }
            return grade;
        }
        
    }
}
