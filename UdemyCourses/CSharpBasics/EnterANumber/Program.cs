using System;

namespace EnterANumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            var userInput = Int32.Parse(Console.ReadLine());

            string message = "Valid";

            message = (userInput > 0 && userInput < 11) ? "Valid" : "invalid";
            Console.WriteLine(message);
        }
    }
}
