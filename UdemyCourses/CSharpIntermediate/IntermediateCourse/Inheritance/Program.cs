using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var programme = new Text();
            programme.Width = 100;
            programme.Copy();
        }
    }
}
