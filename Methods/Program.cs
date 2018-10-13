using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    partial class Program
    {
        static void Main(string[] args)
        {
            // choose a method and invoke here


            // out modifier. You'll probs never use this but you might see it in .Net so good to know.
            // if conversion is successful, var result will be true (this code returns a bool)
            int number;
            var result = int.TryParse("abc", out number);
            if(result)
                Console.WriteLine(number);
            else
                Console.WriteLine("conversion failed soz");
            Console.ReadKey();
        }

        static void UseParamsInCalculator()
        {
            var calculator = new Calculator();

            // don't have to use array notiation because we've used params in the method
            Console.WriteLine(calculator.Add(1, 2));
            Console.WriteLine(calculator.Add(122, 90));
            Console.WriteLine(calculator.Add(34573627, 13));
            Console.ReadKey();
        }

        static void UsePoints()
        {
            try
            {
                // here we make a Point object and call the second version of the Move method. It takes
                // a Point object as an argument. moves one Point to a whole new Point
                var mapPoint = new Point(0, 10);
                // if the argument you pass to Move is null, it willthrow an exception referencing newLocation
                mapPoint.Move(new Point(20, 60));
                Console.WriteLine("Version 2 of the Move method: mapPoint is now at ({0}, {1})", mapPoint.X, mapPoint.Y);

                // now we use the first version of the Move method that just takes an x and y
                mapPoint.Move(20, 0);
                Console.WriteLine("Version 1 of the Move method: mapPoint is now at ({0}, {1})", mapPoint.X, mapPoint.Y);
                Console.ReadKey();
            }
            catch (Exception)
            {
                Console.WriteLine("An unexpected error has occured soz! Oh well...");
                Console.ReadKey();
            }
        }
    }
}
