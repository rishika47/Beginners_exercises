//3.Write a program and ask the user to enter 5 numbers.
//If a number has been previously entered, display an error message and ask the user to re-try.
//Once the user successfully enters 5 unique numbers, sort them and display the result on the console.

using System;
namespace Beginners_Exercise_Program12
{
    public class Program12
    {
        public static void Main()
        {
            var number = new int[5];
            Console.WriteLine("Enter 5 unique numbers");

            for (int i = 0; i < 5; i++)
            {
                number[i] = Convert.ToInt32(Console.ReadLine());
                var numberValue = number[i];

                var currentNumber = Array.IndexOf(number, numberValue);
                if (number[i] == number[0])
                {
                    continue;
                }
                else
                {
                    if (!(currentNumber == number[i]))
                    {
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("Hold on, you already entered that number. Try again.");
                    }
                }

                
                continue;
            }

            Array.Sort(number);
            Console.WriteLine();

            foreach (var n in number)
                Console.WriteLine(n);

            Console.WriteLine();
        }
    }
}

