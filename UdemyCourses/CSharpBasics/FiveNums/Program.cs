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
            var userInputChars = Console.ReadLine().ToCharArray();
            var userInputNums = new List<int>();
            int num;

            foreach (var ch in userInputChars)
            {
                num = Int32.Parse(ch.ToString());
                userInputNums.Add(num);
            }

            foreach (var listNum in userInputNums)
            {
                if (listNum == )
                {
                    
                }
                Console.WriteLine(listNum);
            }

            Console.ReadKey();

        }
    }
}
