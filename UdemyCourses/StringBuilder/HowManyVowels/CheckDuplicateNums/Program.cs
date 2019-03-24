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
            try
            {
                var userInput = Console.ReadLine();



            }

            catch
            {
                Console.WriteLine("Bye bye!");
            }

        }

        public static int CheckForDuplicates(string userInput)
        {
            var numOfAppearances = 0;
            var numOfDuplicates = 0;

            if (!String.IsNullOrWhiteSpace(userInput))
            {
                userInput.Split('-').ToList();
                foreach (var num in userInput)
                {
                    numOfAppearances = userInput.Count(n => n.Equals(num));

                    if (numOfAppearances > 1)
                    {
                        Console.WriteLine($"{num} is a duplicate!");
                        break;
                    }

                    Console.WriteLine($"{num} is unique in your number list.");

                }
            }
            return numOfDuplicates;
            Console.WriteLine("Thank you for those tasty numbers. Ciao!");

        }
    }
}
