using System;
using System.Linq;
using System.Text;

namespace ProceduralProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            // you should always separate the logic from the bits that log to the console
            Console.WriteLine("Welcome to the name reversor! Please enter your enam.. I mean name...");
            var userName = Console.ReadLine();
            var reversedName = ReverseName(userName);

            Console.WriteLine($"Your new name is {reversedName}. Enjoy!");


            Console.ReadKey();
        }

        public static string ReverseName(string userName)
        {
            var reversedNameChars = userName.Reverse();
            var reversedNameStr = new StringBuilder();

            foreach (var ch in reversedNameChars)
            {
                reversedNameStr.Append(ch);
            }
            return reversedNameStr.ToString();
        }
    }
}
