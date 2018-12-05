using System;
using System.Collections.Generic;

namespace FiveNums
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello number friend! Let's play number wang! Please give me " +
                              "five numbers.");

            // need a while loop
            var userInputChars = Console.ReadLine().ToCharArray();
            var userInputNums = new List<int>();
            int num;

            foreach (var ch in userInputChars)
            {
                num = Int32.Parse(ch.ToString());
                userInputNums.Add(num);
            }

            for (var i = 0; i < userInputNums.Count; i++)
            {
                // this don't work
                //if (userInputNums[i] == userInputNums[i - 1])
                //{
                //    Console.WriteLine($"Soz you've already entered {userInputNums[i]}. Please try another set of " +
                //                      $"five numbers.");
                //}
                //Console.WriteLine(listNum);
            }

            Console.WriteLine("Thant's numberwang! Your sorted list of numbers is: ");

            userInputNums.Sort();
            foreach (var number in userInputNums)
            {
                Console.WriteLine(number);
            }


            Console.ReadKey();

        }
    }
}
