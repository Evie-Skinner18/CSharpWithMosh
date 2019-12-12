using System;
using System.Collections.Generic;

namespace Polymorphism.MethodOverriding
{
    // METHOD OVERRIDING
    public class Canvas
    {
        // POLYMORPHISM: many forms. Here we have the concept of Shape, and of drawing a Shape, but those concepts can have mamy forms
        // depending on the objects we have at runtime
        public void DrawShape(List<Shape> shapes)
        {
            foreach (var shape in shapes)
            {
                Console.WriteLine(shape.Draw());                    
            }
        }
    }
}
