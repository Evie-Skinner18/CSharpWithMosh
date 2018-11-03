using System;

namespace MaxValue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Enter a number please...");
            var firstUserNum = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Thanks funky dude. Please can I have another one?");
            var secondUserNum = Int32.Parse(Console.ReadLine());

            var maxValue = (firstUserNum > secondUserNum) ? firstUserNum : secondUserNum;
            Console.WriteLine("The maximum of your two numbers is {0}", maxValue);
        }
    }
}
