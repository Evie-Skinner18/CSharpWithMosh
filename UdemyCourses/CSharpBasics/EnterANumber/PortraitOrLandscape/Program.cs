using System;

namespace PortraitOrLandscape
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hey party person! I see you have a lovely piece of art in your hand. What is its" +
                              "length?");
            int length = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Sweet as. What's the girth playuhh?");
            int width = Int32.Parse(Console.ReadLine());

            var message = (length > width) ? "This is a portrait!" : "Oh no it's a boring landscape";
            Console.WriteLine(message);
        }
    }
}
