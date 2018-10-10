using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
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

                throw;
                //Console.ReadKey();
            }
            
        }
    }
}
