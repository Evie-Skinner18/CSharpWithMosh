using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReverseName
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the name reversor! Please enter your enam.. I mean name...");
            var userInput = (Console.ReadLine()).ToCharArray();

            var reversedNameChars = userInput.Reverse();
            var reversedNameStr = new StringBuilder();

            foreach (var ch in reversedNameChars)
            {
                reversedNameStr.Append(ch);
            }

            Console.WriteLine($"Your new name is {reversedNameStr}. Enjoy!");


            Console.ReadKey();
        }
    }
}
