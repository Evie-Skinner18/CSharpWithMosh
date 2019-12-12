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

            // if we use polymorphism (a Shape can have many forms), the canvas doesn't ahve to worry about what kind of shape is going in            
            var canvas = new Canvas();
            canvas.DrawShape(shapes);
        }
    }
}
