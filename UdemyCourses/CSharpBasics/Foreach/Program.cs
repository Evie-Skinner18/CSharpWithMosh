using System;

namespace Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("reveal the truth by tapping on a key!");
            var truth = "Evie is a legend";

            foreach (var character in truth)
            {
                Console.WriteLine(character);
                // reveal the truth by tapping on a key!
                Console.ReadKey();
            }


            var nums = new int[] {1, 2, 3, 4, 5};

            foreach (int num in nums)
            {
                Console.WriteLine(num);
                Console.ReadKey();
            }
        }
    }
}
