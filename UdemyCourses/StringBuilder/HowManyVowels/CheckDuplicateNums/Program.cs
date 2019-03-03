using System;
using System.Linq;
using System.Collections.Generic;

namespace CheckDuplicateNums
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hey girlfrenn. Type in some numbers separated by hyphens and I'll check for any duplicates!");
            var userInput = Console.ReadLine().Split('-').ToList();

            foreach (var num in userInput)
            {
                Console.WriteLine(num);
            }

        }
    }
}
