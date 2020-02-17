//Jacob York
using System;

namespace String_Manipulation
{
    class Program
    {
        static string sentence = "Programming today is a race between software engineers striving to build bigger and better idiot - proof programs, and the universe trying to build bigger and better idiots.So far, the universe is winning.";

        static void Main(string[] args)
        {
            Console.WriteLine(sentence);

            Console.WriteLine("What word would you like to look for?");
            string lookupWord = Console.ReadLine();

            Console.WriteLine($"What word would you like to change {lookupWord} to?");
            string replaceWord = Console.ReadLine();

            bool doesContainWord = sentence.Contains(lookupWord);

            if (doesContainWord == true)
            {
                //the sentence has the lookupWord in it
                string newSentence = sentence.Replace(lookupWord, replaceWord);
                Console.WriteLine(newSentence);
            }
            else
            {
                //the sentence DOES NOT have the lookupWord in it
                Console.WriteLine($"Sorry, I could not find your word {lookupWord}.");

                for (int i = lookupWord.Length - 1; i >= 0; i--)
                {
                    Console.Write(lookupWord[i]);
                }
            }

            Console.ReadKey();

        }
    }
}
