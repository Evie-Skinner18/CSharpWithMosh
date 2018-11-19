using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int userGuess;
            var numberOfGuesses = 0;
            Console.WriteLine("Welcome to the guessing game! Type 'exit' at any time to exit the game." +
                              "Let me tell you da rulez.");
            Console.Write("I will pick a number between 1 amd 10; you have four chances to guess it, ok?");

            var userInput = Console.ReadLine();
            if (userInput == "ok")
            {
                Console.Write("Let's play bitch! Guess a number between 1 and 10.");
                userInput = Console.ReadLine();
                while (userInput != "exit")
                {
                    numberOfGuesses++;
                    if (numberOfGuesses >= 4)
                    {
                        break;
                    }
                    else
                    {
                        userGuess = Int32.Parse(userInput);
                    }
                    Console.WriteLine("Hello World!");
                }
            }

            Console.WriteLine( "ciao!");
        }
    }
}
