//2.Write a program and ask the user to enter their name.
//Use an array to reverse the name and then store the result in a new string.
//Display the reversed name on the console.

using System;
namespace Beginners_Exercise
{
    public class Program11
    {
        public static void Main()
        {
           

            Console.WriteLine("User Please enter your Name !");
            string name = Console.ReadLine();
            char[] chars = name.ToCharArray();

            for (int i = chars.Length-1; i >0; i--)
            {
                Console.Write(chars[i]);
            }
          
        }
    }
}