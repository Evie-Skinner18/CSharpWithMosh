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


            while (userInput != "quit")
            {
            try
                {
                    Console.WriteLine("Please enter a number (I'll keep asking for more numbers until you type" +
                                            "'quit').");
                    var userStringNum = Console.ReadLine().ToLower();
                    var userNum = Int32.Parse(userStringNum);
                    numList.Add(userNum);
                    Console.WriteLine("Please enter another number");

                }
                catch (Exception)
                {

                    break;
                }
            }
            Console.WriteLine("Here is a sorted list of your numbers:");
            foreach (var num in numList)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("Byebye!");
            Console.ReadKey();
        }
    }
}
