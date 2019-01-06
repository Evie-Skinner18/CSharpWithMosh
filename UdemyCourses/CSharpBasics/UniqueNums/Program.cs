using System;
using System.Collections.Generic;

namespace UniqueNums
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the unique number finder! Please enter something cool like 'let's go!'" +
                              "or type 'quit' to exit.");
            var userInput = Console.ReadLine().ToLower();
            var numList = new List<int>();


            while (userInput != "quit" && numList.Count < 5)
            {
            try
                {
                    Console.WriteLine("Please enter a number (I'll keep asking for more numbers until you've entered" +
                                            " five of them).");
                    var userStringNum = Console.ReadLine().ToLower();
                    var userNum = Int32.Parse(userStringNum);
                    if (numList.Contains(userNum))
                    {
                        Console.WriteLine("You've entered a duplicate number! Please put in unique numbers." +
                                              "I'll get rid of that duplicate one for you...");
                        numList.Remove(userNum);
                    }
                    numList.Add(userNum);
                }
                catch (Exception)
                {

                    break;
                }
            }
            if (numList.Count > 0)
            {
                numList.Sort();
                Console.WriteLine("Here is a sorted list of your numbers:");
                foreach (var num in numList)
                {
                    Console.WriteLine(num);
                }
            }
         
            Console.WriteLine("Byebye!");
            Console.ReadKey();
        }
    }
}
