using System;
using Classes.Maths;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            var evie = new Person();
            evie.FirstName = "Evie";
            evie.LastName = "Smellybick";
            evie.Introduce();

            var newCalculator = new Calculator();
            var sum = newCalculator.Add(4983, 957);

            // WriteLine is static method so we don't need to make a new Console object each time
            // we call this
            Console.WriteLine("The sum is {0}", sum);
           
            Console.ReadKey();
        }
    }
}
