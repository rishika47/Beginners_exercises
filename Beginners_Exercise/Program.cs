//3 .Write a program and ask the user to enter a number.
//Compute the factorial of the number and print it on the console.
//For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 and
//display it as 5! = 120.

using System;
namespace Beginners_Exercise
{
    public class Program7
    {
        public static void Main()
        {
            var factorial = 1;
            Console.WriteLine("Enter the Number : ");
            var number = Convert.ToInt32(Console.ReadLine());
           
                for (var i = 1; i <= number; i++)
            { 

                    factorial *= i;


                Console.WriteLine("The Factorial of the Number is : " + factorial);
            }
        }
    }
}

