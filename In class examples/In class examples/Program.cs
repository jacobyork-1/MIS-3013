//Jacob York
using System;

namespace In_class_examples
{
    class Program
    {
        static void Main(string[] args)
        {
            //                  01234
            string firstName = "Jacob";
            string lastName = "York";


            Console.WriteLine($"You have {firstName.Length.ToString("5")} characters in your first name.");
            Console.WriteLine($"You have {lastName.Length.ToString("4")} characters in your last name.");
            char firstInitial = firstName[0];
            char lastInitial = lastName[0];

            //Console.WriteLine(firstName.ToUpper()[0]);
            //Console.WriteLine(firstName.ToUpper()[1]);
            //Console.WriteLine(firstName.ToUpper()[2]);
            //Console.WriteLine(firstName.ToUpper()[3]);
            //Console.WriteLine(firstName.ToUpper()[4]);

            firstName = firstName.ToUpper();
            //Output every charater of the firstname on a seperate line with BIG LETTERS
            for (int i = 0; i < firstName.Length; i = i + 1)
            {
                char currentLetter = firstName[i];
                Console.WriteLine(currentLetter);
            }

            Console.WriteLine("Output every other letter of the first name");
            for (int i = 0; i < firstName.Length; i = i + 2)
            {
                char currentLetter = firstName[i];
                Console.Write(currentLetter + " ");
            }
            Console.WriteLine();
            Console.WriteLine($"Your initials are {firstInitial}.{lastInitial}");

            //Jacob York
            //kroY bocaJ
            string name = firstName + " " + lastName;

            string fName = name.Substring(0, firstName.Length);
            var pieces = name.Split(' ');
            fName = " " + fName + " ";
            fName = fName.Trim();
            for (int i = name.Length - 1; i >= 0; i--)
            {
                Console.Write(name[i]);
            }
            
            Console.ReadKey();
        }
    }
}
