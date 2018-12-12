using System;
using System.Collections.Generic;
using System.Linq;

namespace FiveNums
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello number friend! Let's play number wang! Please give me " +
                              "five numbers.");

            // need a while loop
            var userInputStr = Console.ReadLine().Split("");
            var userInputChars = userInputStr[0].Trim().ToCharArray().ToList();

            //remove commas and spaces
            for (var i = 0; i < userInputChars.Count; i++)
            {
                if (userInputChars[i] == ',')
                    userInputChars.Remove(userInputChars[i]);
            }

            var userInputNums = new List<int>();
            int num;

            foreach (var ch in userInputChars)
            {
                var chString = ch.ToString();
                if (chString == "")
                {
                    userInputChars.Remove(ch);
                }
                num = Int32.Parse(chString);
                userInputNums.Add(num);

            }

            //for (var i = 0; i < userInputNums.Count; i++)
            //{
            //    if (userInputNums[i] == userInputNums[i - 1])
            //    {
            //        Console.WriteLine($"Soz you've already entered {userInputNums[i]}. Please try another set of " +
            //                          $"five numbers.");
            //    }
            //}

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
