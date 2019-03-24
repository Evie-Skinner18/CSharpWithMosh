using System;

namespace CalcEnteredNums
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello friend. Please enter a number and I will calculate allthese delish" +
                              "doughnuts for you! Or enter ok to exit the app.");

            var userInput = Console.ReadLine();
            int sum = 0;
            int userNum;

            while (userInput != "ok" || userInput !="OK")
            {
                if (userInput != "ok" || userInput != "OK")
                {
                    userNum = Int32.Parse(userInput);
                    sum = sum + userNum;
                    Console.WriteLine("The sum so far is " + sum);
                    Console.WriteLine("Please enter another number...");
                    userInput = Console.ReadLine();
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine("Bye bye!");

        }
    }
}
