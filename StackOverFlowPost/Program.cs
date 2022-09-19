using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverflow_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var solutionPost = new Post();

            solutionPost.Title = "Adding a README.md file to a c# project in Visual Studio 2015";
            solutionPost.Description = "Look in the top of the solution explorer for the option add hidden files. It should appear with dotted outline.\n If you wish to add it to the project you can right click and press \"add to project\"";
            solutionPost.CreatedTime = new DateTime(2015, 12, 21);

            solutionPost.VoteUp();
            solutionPost.VoteUp();
            solutionPost.VoteUp();
            solutionPost.VoteUp();
            Console.WriteLine("Should Have 4 Votes");

            solutionPost.PrintFullPost();

            solutionPost.VoteDown();
            solutionPost.VoteDown();
            Console.WriteLine("Should Have 2 Votes");
            solutionPost.PrintFullPost();
        }


    }
}
