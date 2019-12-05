using System;

namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello and welcome to the stopwatch!");

            var watch = new Stopwatch();
            Console.WriteLine("Start the clock!");
            Console.Beep(38, 6000);
            var startTime = watch.Start();
            Console.WriteLine("Stop the clock!");
            var duration = watch.Stop();

            Console.WriteLine($"The duration was {duration}");
        }
    }
}
