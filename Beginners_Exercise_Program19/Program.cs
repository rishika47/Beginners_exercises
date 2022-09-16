// 1- Write a program that reads a text file and displays the number of words.
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
            Console.WriteLine(words.Length);

        }
    }
}