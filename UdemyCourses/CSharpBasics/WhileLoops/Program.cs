using System;

namespace WhileLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            // if you don't know how many times the loop will iterate , it's best to use
            // while. for is better for a discrete number
            while (true)
            {
                Console.Write( "type your name: ");
                var userInput = Console.ReadLine();

                // this string method checks fornull or nothing and returns bool. So when
                // the user presses enter key it will exit!
                if (!String.IsNullOrWhiteSpace(userInput))
                {
                    Console.WriteLine("@Echo: " + userInput);
                    // cont means go back to beginning of the loop
                    continue;
                }

                Console.WriteLine("byebye!");
                break;
                
                
            }
        }
    }
}
