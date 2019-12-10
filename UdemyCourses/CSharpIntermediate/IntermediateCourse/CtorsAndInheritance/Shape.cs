using System;

namespace CtorsAndInheritance
{
    // CASTING
    public class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public void Draw()
        {
            Console.WriteLine("Drawing a nice shape for you...");
        }
    }
}
