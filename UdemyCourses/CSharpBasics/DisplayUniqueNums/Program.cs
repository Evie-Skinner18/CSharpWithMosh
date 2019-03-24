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
                    if (userStringNum == "display")
                    {
                        foreach (var num in numList)
                        {
                            Console.WriteLine(num);
                        }
                    }
                    var userNum = Int32.Parse(userStringNum);
                    if (numList.Contains(userNum))
                    {
                        numList.Remove(userNum);
                    }
                    numList.Add(userNum);
                    Console.WriteLine("Thank you! Type 'display' if you want to me to display the unique numbers" +
                                      "you have entered.");

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
