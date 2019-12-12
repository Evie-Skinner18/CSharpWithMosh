using Polymorphism.MethodOverriding;
using System;
using System.Collections.Generic;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello and welcome to the canvas!");

            var shapes = new List<Shape>()
            {
                new Circle(),
                new Triangle(),
                new Rectangle()
            };

            var canvas = new Canvas();
            canvas.DrawShape(shapes);
        }
    }
}
