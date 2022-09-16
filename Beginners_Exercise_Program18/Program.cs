// Write a program and ask the user to enter an English word.
// Count the number of vowels (a, e, o, u, i) in the word.
// So, if the user enters "inadequate", the program should display 6 on the console.
using System;
using System.Linq;

namespace Beginners_Exercise
{
    public static class Program18
    {
        public static void Main()
        {
            Console.WriteLine("Type in a word you wish to know how many vowels has:");
            var input = Console.ReadLine();

            Console.WriteLine("The word '{0}' has {1} vowels", input, CountVowelsInWord(input));
        }

        private static int CountVowelsInWord(string word)
        {
            var counter = 0;
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            foreach (var letter in word)
            {
                if (vowels.Contains(letter))
                    counter++;
            }

            return counter;
        }
    }
}

