using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {


        }

        static void UseParams()
        {
            var calculator = new Calculator();
            calculator.Add(3, 9);
            calculator.Add(12, 93, 155);
            calculator.Add(new int[] { 8, 13, 33, 101});
        }

        static void UsePoints()
        {
            try
            {
                Console.WriteLine("Hello and welcome to the pointy point!");

                var point = new Point(10, 20);
                Console.WriteLine($"The point has started off at {point.X}, {point.Y}");

                // Move() has several overloads so it's easier for the caller of the method to be funky
                point.Move(12, 22);
                Console.WriteLine($"The point's new location is {point.X}, {point.Y}");

                point.Move(null);
                Console.WriteLine($"The point has arrived at its final destination of {point.X}, {point.Y}");

            }

            catch (Exception ex)
            {
                Console.WriteLine("Oh no something's gone wrong soz!");
            }

        }

    }

}
