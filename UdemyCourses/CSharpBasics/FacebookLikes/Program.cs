using System;
using System.Collections.Generic;

namespace FacebookLikes
{
    class Program
    {
        static void Main(string[] args)
        {
            var userInput = Console.ReadLine().ToLower();
            var friendsWhoLike = new List<string>();

            while (!String.IsNullOrWhiteSpace(userInput))
            {
                Console.WriteLine("Hello slave of Facey B. I am your friend. Let's see how many friends are pretending" +
                                  "to like your pathetic posts.");
            }



        }
    }
}
