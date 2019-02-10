using System;

namespace DateTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            // different ways to create a timespan
            var timeSpan = new TimeSpan(1, 2, 3);
            var nextTimeSpan = new TimeSpan(1, 0, 0);
            var anotherTimeSpan = TimeSpan.FromHours(1);

            // subtracting one datetime from anotehr returns a timespan
            var startListeningToMusic = DateTime.Now;
            var end = startListeningToMusic.AddHours(3);
            var duration = end - startListeningToMusic;

            // properties

            // minutes returns the minutes in the minutes bit of the timespan
            Console.WriteLine($"minutes: {timeSpan.Minutes}");
            // total minutes is the whole timespan expressed in minutes
            Console.WriteLine($"Total minutes: {timeSpan.TotalMinutes}");

            // add 5h to our original timespan
            Console.WriteLine($"Add: {timeSpan.Add(TimeSpan.FromHours(5))}");
            // subtract
            Console.WriteLine($"Add: {timeSpan.Subtract(TimeSpan.FromSeconds(2))}");
        }
    }
}
