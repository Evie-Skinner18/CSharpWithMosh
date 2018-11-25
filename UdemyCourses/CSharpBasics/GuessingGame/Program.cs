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
            Console.Write("I will pick a number between 1 and 10; you have four chances to guess it, ok?");
            
            var userInput = Console.ReadLine();
            if (userInput == "ok")
            {
                var random = new Random();
                var randomNum = random.Next(1, 10);
                Console.Write("Let's play bitch! Guess a number between 1 and 10.");
                Console.Write(randomNum);

                while (userInput != "exit")
                {
                    if (numberOfGuesses < 4)
                    {
                        Console.Write("You have " + (4 - numberOfGuesses).ToString()
                                          + " guesses left. Choose wisely...");
                        userInput = Console.ReadLine();
                        userGuess = Int32.Parse(userInput);
                        numberOfGuesses++;

                        if (userGuess == randomNum)
                        {
                            Console.Write("You've won the game on guess number "
                                                + numberOfGuesses + ". Well done!");
                        }
                        else
                        {
                            Console.WriteLine("Not quite my number. Have another go!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Ooh no more guesses soz!");
                        break;
                    }
                    
                }
            }

            Console.WriteLine( "ciao!");
            Console.ReadKey();
        }
    }
}
