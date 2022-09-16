//3.Write a program and ask the user to enter the width and height of an image.
//Then tell if the image is landscape or portrait.
using System;
namespace Beginners_Exercise
{
    public class Program3
    {
        public static void Main(string[] args)

        {
            Console.WriteLine("Enter the width and height of the image to know the image is Landscape or Portrait");
            Console.WriteLine("Enter the width for the image: " );
            var width = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the height for the image: " );
            var height = Convert.ToInt32(Console.ReadLine());

            if(width > height)
            {
                Console.WriteLine("The Image is Landscape");

            }
            else
            {
                Console.WriteLine("The Image is Portrait");
            }
        }
    }
}