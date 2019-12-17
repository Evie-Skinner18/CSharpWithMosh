using System;
using Interfaces.Testability;
using Interfaces.Extensibility;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Hello I'm ready for your order!");

            var shippingCalculator = new ShippingCalculator();
            var orderProcessor = new OrderProcessor(shippingCalculator);
            var order = new Order()
            {
                Shipment = new Shipment()
                {
                    Cost = 12f,
                    ShippingDate = DateTime.Today.AddDays(3)
                },
                TotalPrice = 14f
            };

            orderProcessor.ProcessOrder(order);

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.BackgroundColor = ConsoleColor.DarkRed;
            var tellyLogger = new TvLogger();
            Console.WriteLine(tellyLogger.LogInfo("Coucou from the tellyLogger!"));

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.BackgroundColor = ConsoleColor.Yellow;
            var dbMigrator = new DbMigrator(tellyLogger);
            Console.WriteLine(dbMigrator.Migrate());
        }
    }
}
