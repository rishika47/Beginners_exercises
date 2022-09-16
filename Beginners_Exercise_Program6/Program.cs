//2.Write a program and continuously ask the user to enter a number or "ok" to exit.
//Calculate the sum of all the previously entered numbers and display it on the console.

using System;

namespace Beginners_Exercise
{
    
    public static class SumAllEnteredNumbers
    {
        public static void Main()
        {
            var sum = 0;
            while (true)
            {
                Console.WriteLine("Enter a number: ");
                var input = Console.ReadLine();

                if (input == "ok")
                    break;

                var number = Convert.ToInt32(input);

                sum += number;
            }

            Console.WriteLine("Sum of all the numbers is: {0}", sum);
        }
    }
}
