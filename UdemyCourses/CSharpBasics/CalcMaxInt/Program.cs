using System;

namespace CalcMaxInt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome! I want to do some number crunching. Please can you give me a list " +
                              "of integers separated by commas to crunch on?");

            var userInput = Console.ReadLine();

            var stringNums = userInput.Split(',', userInput.Length);
            var max = 0;

            foreach (var stringNum in stringNums)
            {
                int num = Int32.Parse(stringNum);
                max = num > max ? num : max;
            }
            Console.WriteLine("The maximum of your values is " + max);
        }
    }
}
