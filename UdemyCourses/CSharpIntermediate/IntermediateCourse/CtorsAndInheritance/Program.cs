using System;
using System.Collections;
using System.Collections.Generic;
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

            // BOXING
            var arrList = new ArrayList();
            arrList.Add(1);

            var number = (int)arrList[0];

            // no boxing happens with normal Lists because they are typesafe. A list of ints can only add ints
            var anotherList = new List<int>();
            anotherList.Add(5);
            
                
            

        }
    }

    
}
