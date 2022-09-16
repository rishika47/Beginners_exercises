//5.Write a program and ask the user to enter a series of numbers separated by comma.
//Find the maximum of the numbers and display it on the console.
//For example, if the user enters “5, 3, 8, 1, 4", the program should display 8.
using System;
namespace Beginners_Exercise_Program9
{
    public class Program9
    {
        public static void Main()
        {
            Console.WriteLine("User Please Enter !");
            string str = Console.ReadLine();
            var splitted = str.Split(",");
            List<int> list = new List<int>();
            for (int i = 0; i < splitted.Length; i++)
            {
                list.Add(Convert.ToInt32(splitted[i]));
            }
            list.Sort();
            Console.WriteLine(list[list.Count - 1]);

        }
    }
}

