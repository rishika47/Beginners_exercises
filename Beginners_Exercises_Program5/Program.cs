//5.Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder.
//Display the count on the console.

using System;
namespace Beginners_Program_Exercises
{
    public class Program_5
    {
        public static void Main()
        {
            var count = 2;
            Console.WriteLine("Display count of number divisible by 3 from 1 to 100");

            for (var i = 0; i < 100; i++)
                if (i % 3 == 0)
                 count++;

            Console.WriteLine("The count of numbers between 1 to 100 , divisible by 3 are : " +count);


        }
    }
}