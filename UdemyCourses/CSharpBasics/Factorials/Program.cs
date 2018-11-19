using System;

namespace Factorials
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Factorial-ifier! Please enter a number...");
            var userInput = Int32.Parse(Console.ReadLine());
            int result;

            for (int i = 0; i < userInput; i++)
            {
                result = userInput * (userInput - i);
               
            }
            Console.WriteLine(userInput + "! = " + result);

            Console.ReadKey();
        }
    }
}
