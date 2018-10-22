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
        }
    }
}
