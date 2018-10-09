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
            var mapPoint = new Point(0, 10);
            mapPoint.Move(new Point(40, 60));
            Console.WriteLine("mapPoint is now at ({0}, {1})", mapPoint.X, mapPoint.Y);

        
            Console.ReadKey();
        }
    }
}
