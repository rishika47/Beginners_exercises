//2.Write a program which takes two numbers from the console and displays the maximum of the two.

using System;
namespace Beginners_Exercise
{
    class Program2
    {
        public static void Main(string[] args)
        {
            var maximum = 0;
            Console.WriteLine("Enter the first number : ");
            var number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number : ");
            var number2 = Convert.ToInt32(Console.ReadLine());

            if(number1 > number2)
            {
                maximum = number1;
            }
            else
            {
                 maximum = number2;
            }
            Console.WriteLine("The maximum of Two Numbers Are : " +maximum);
        }
    }
}
