using System;
using System.Collections;
using System.IO;

namespace CtorsAndInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // Car and Vehicle: ctors adn inheritance
            // var car  = new Car("XHFJBSDJFH");

            // implicit casting
            Text text = new Text();
            Shape shape = text;

            text.Width = 200;
            shape.Width = 100;

            // this outputs 100 because text and shape are refs to same object
            Console.WriteLine(text.Width);

            //StreamReader reader = new StreamReader(new FileStream());

            Shape triangle = new Text();
            Text paragraph = (Text)triangle;
            

        }
    }
}
