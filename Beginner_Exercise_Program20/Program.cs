// 2- Write a program that reads a text file and displays the longest word in the file.
using System;
using System.IO;
namespace Beginners_Exercise
{
    public class Program19
    {
        public static void Main()
        {
            string path = @"C:\.net Training\course.txt";
            var stringData = File.ReadAllText(path);
            var words = stringData.Split(' ');


            var longestWord = "";
            foreach (var word in words)
            {
                if (longestWord.Length < word.Length)
                    longestWord = word;
            }
            Console.WriteLine("The longest word in the word.txt file is: " + longestWord);
        }
    }
}