//Jacob York
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes___Student1
{
    class Student
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public List<string> CourseNames { get; set; }

        public List<string> CourseGrades { get; set; }


        public Student()
        {
            FirstName = "";
            LastName = "";
            List<string> CourseNames = new List<string>();
            List<string> CourseGrades = new List<string>();
        }

        public Student(string first, string second)
        {
            FirstName = first;
            LastName = second;
            List<string> CourseNames = new List<string>();
            List<string> CourseGrades = new List<string>();
        }

        public double CalculateGPA()
        {
            double TotalPointsEarned = 1;
            double TotalCreditsAttempted = 1;

            double GradePoints = 0;


            switch (LetterGrade)
            {
                case 'A':
                    GradePoints = 4; break;
                case 'B':
                    GradePoints = 3; break;
                case 'C':
                    GradePoints = 2; break;
                case 'D':
                    GradePoints = 1; break;
                case 'F':
                    GradePoints = 0; break;
            }
            return GradePoints;

            return TotalPointsEarned / TotalCreditsAttempted;
        }
    }
}
