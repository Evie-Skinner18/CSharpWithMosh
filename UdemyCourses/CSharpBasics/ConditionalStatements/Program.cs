using System;

namespace ConditionalStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            //int hour = 10;
            //if (hour > 0 && hour < 12)
            //    Console.WriteLine("good morning!");
            //else if (hour > 12 && hour < 18)
            //    Console.WriteLine("Good afternoon!");
            //else
            //Console.WriteLine("Good evening handsome ;-> ");

            bool isGoldCustomer = true;
            float price = (isGoldCustomer) ? 19.95f : 40.00f;
            Console.WriteLine(price);

            var season = Season.Autumn;

            switch (season)
            {
                case Season.Spring:
                    Console.WriteLine("Spring has sprung!");
                    break;
                case Season.Summer:
                    Console.WriteLine("Summer summer summer ti-iime");
                    break;
                // This is more DRY if you want the same action to be performed for two different cases
                case Season.Autumn:
                case Season.Winter:
                    Console.WriteLine("Ooh I love those crunchy leaves underfoot! " +
                                      "Time to wrap up warm in your sheepy coat.");
                    break;
                default:
                    Console.WriteLine("Seasons change... but love stays the same.");
                    break;
            }
        }
    }
}
