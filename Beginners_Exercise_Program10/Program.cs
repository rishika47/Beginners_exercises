//10.1- When you post a message on Facebook, depending on the number of people who like your post,
//Facebook displays different information.
//If no one likes your post, it doesn't display anything.
//If only one person likes your post, it displays: [Friend's Name] likes your post.
//If two people like your post, it displays: [Friend 1] and[Friend 2] like your post.
//If more than two people like your post, it displays: [Friend 1], [Friend 2]
//and[Number of Other People] others like your post.
//Write a program and continuously ask the user to enter different names,
//until the user presses Enter (without supplying a name).
//Depending on the number of names provided, display a message based on the above pattern.

using System;
namespace Beginners_Exercise_Program10
{
    public class Program10
    {
        public static void Main()
        {
            Console.WriteLine("Please enter the names !");
            var name = Console.ReadLine();
            var names = new List<string>();

            names.Add(name);
            for (int i = 0; i < names.Count; i++)
            {
                if (names.Count > 0 && names.Count <= 1)
                    Console.WriteLine(names[i] + " Likes your Post !");
                if (names.Count > 1 && names.Count <= 2)
                    Console.WriteLine(names[i] + " Likes your Post !");
                if (names.Count > 2)
                    Console.WriteLine(names[i] + "Likes Your Post !");
            }

        }
    }
}