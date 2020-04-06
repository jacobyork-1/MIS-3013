//Jacob York
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes___Student1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your first name.");
            string FN = Console.ReadLine();

            Console.WriteLine("Please enter your last name.");
            string LN = Console.ReadLine();

            Student Student = new Student
            {
                FirstName = "",
                LastName = "",
            };

            Console.WriteLine("Please enter the course name. (e.g. MIS3013, MIS3033)");
            CourseNames = Console.ReadLine();
            List<string> CourseNames = new List<string>
            {
                Student
            };

            Console.WriteLine("Please enter your corresponding grades for each course. (e.g. A, B, C, D, F)");
            CourseGrades = Console.ReadLine();
            List<string> CourseGrades = new List<string>
            {
                Student
            };

            Console.WriteLine($"The GPA for {Student.FirstName} {Student.LastName} is {Student.CalculateGPA}.");
            Console.ReadKey();
        }
    }
}
