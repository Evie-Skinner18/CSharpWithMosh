using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {

            byte number = 2;
            int count = 10;
            float totalPrice = 20.97f;
            char firstLetter = 'E';
            string bitch = "Bitch";
            //const pi = 3.14f;

            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(firstLetter);
            Console.WriteLine("Your mum is a {0}, {1}",bitch, firstLetter);
            Console.ReadKey();
        }
    }
}
