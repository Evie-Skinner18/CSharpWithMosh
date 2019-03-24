using System;

namespace SpeedCamera
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the speed camera... please enter the speed limit");
            var speedLimit = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Ta for setting the speed limit. Please can you enter the speed of your car?");
            var currentSpeed = Int32.Parse(Console.ReadLine());

            string speedMessage;
            var pointsOnLicence = 0;

            if (currentSpeed > speedLimit)
            {
                speedMessage = "You are over the speed limit road hog!";
                if (currentSpeed == speedLimit + 5)
                {
                    // don't know how to increment 1 for every 5 km/h above the speed limit
                    pointsOnLicence++;
                }

            }
            else
            {
                speedMessage = "You're driving safely";
            }

            Console.WriteLine(speedMessage);
            Console.WriteLine("You have accrued {0} points on your licence", pointsOnLicence);
        }
    }
}
