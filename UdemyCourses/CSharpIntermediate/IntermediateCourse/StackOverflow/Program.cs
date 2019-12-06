using System;

namespace StackOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello and welcome to stack OVerflow!");

            var dibbysPost = new Post("I Love Ale", DateTime.Now);
            var dibbysDescription = dibbysPost.AddDescription("I love a nice glass of kriek");
            dibbysPost.UpVotePost();

            Console.WriteLine(dibbysPost.Title);
            Console.WriteLine(dibbysDescription);
            Console.WriteLine($"Dibby's post has a vote value of {dibbysPost.GetVoteValue()}");

            dibbysPost.UpVotePost();
            Console.WriteLine($"Now Dibby's post has a vote value of {dibbysPost.GetVoteValue()}");


        }
    }
}
