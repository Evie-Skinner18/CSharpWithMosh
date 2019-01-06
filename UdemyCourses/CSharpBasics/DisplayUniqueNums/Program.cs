using System;
using System.Collections.Generic;

namespace DisplayUniqueNums
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello and welcome to another thrilling edition of numberwang! Please continuously" +
                              " enter a number or type 'quit' to exit. You can have duplicates this time." +
                              "Type something to continue...");
            var userInput = Console.ReadLine().ToLower();
            var numList = new List<int>();

            while (userInput != "quit")
            {
                try
                {
                    Console.WriteLine("Please enter a number");
                    var userStringNum = Console.ReadLine().ToLower();
                    if (userStringNum == "quit")
                    {
                        break;
                    }
                    var userNum = Int32.Parse(userStringNum);
                    numList.Add(userNum);
                    Console.WriteLine("Thank you!");

                }
                catch (Exception)
                {
                    break;

                }

            }
            Console.WriteLine("Ciao!");
        }
    }
}
