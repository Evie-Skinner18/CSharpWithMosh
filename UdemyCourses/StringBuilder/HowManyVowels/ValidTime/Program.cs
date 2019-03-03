using System;

namespace ValidTime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello and welcome to the time checker! Please enter a time in the 24h time format," +
            	" for example 13:00");
            var userTime = new DateTime();
            var isValidTime = false;

            try
            {
                userTime = DateTime.Parse(Console.ReadLine());
                isValidTime = userTime > DateTime.Parse("00:00") && userTime < DateTime.Parse("23:59");

                var message = isValidTime ? "Ok" : "Invalid time";
                Console.WriteLine(message);
            }

            catch
            {
                Console.WriteLine("Invalid time");
            }

            Console.ReadKey();


        }
    }
}
