using System;
using System.Collections.Generic;
using System.Linq;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //create an array of type int with a size of 3
            int[] studentIDs = new int[3];
            string[] studentNames = { "Adam", "Katie", "Micah" };
            //these are parallel arrays, values at the same index correlate to eachother

            //[0]      [1]       [2]
            //["Adam"] ["Katie"] ["Micah"]
            studentIDs[0] = 1;
            studentIDs[1] = 2;
            studentIDs[2] = 3;
            //index out of range because we only have space for 3 values - studentIDs[3] = 4;

            Console.WriteLine($"Student with ID {studentIDs[0]} has a name of {studentNames[0]}");
            for (int i = 0; i < studentIDs.Length; i++) //could also do studentNames.Length as they are PARALLEL
            {
                Console.WriteLine($"Student with ID {studentIDs[i]} has a name of {studentNames[i]}");
            }

            //do the same thing but with lists
            //() = method

            List<int> studIDs = new List<int>();
            studIDs.Add(4);
            studIDs.Add(5);
            studIDs.Add(6);
            List<string> studNames = new List<string>();
            studNames.Add("Lakin");
            studNames.Add("Grant");
            studNames.Add("Eric");

            for (int i = 0; i <studIDs.Count; i++)
            {
                Console.WriteLine($"Student with ID {studIDs[i]} has a name of {studNames[i]}");
            }

            //combine array data and list data into a dictionary 
            Dictionary<int, string> students = new Dictionary<int, string>();
            //students.Add(1, "Adam")
            for (int i = 0; i < studIDs.Count; i++)
            {
                if(students.ContainsKey(studentIDs[i]) == false)
                {
                    students.Add(studentIDs[i], studentNames[i]);
                }
                if(students.ContainsKey(studIDs[i]) == false)
                {

                }
            }
            Console.WriteLine($"The dictionary has {students.Count()} students.");
            Console.ReadKey();
        }
    }
}
