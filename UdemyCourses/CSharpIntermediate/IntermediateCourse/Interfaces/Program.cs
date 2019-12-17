using System;
using Interfaces.Testability;
using Interfaces.Extensibility;
using Interfaces.Polymorphism;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Hello I'm ready for your order!");

            //var shippingCalculator = new ShippingCalculator();
            //var orderProcessor = new OrderProcessor(shippingCalculator);
            //var order = new Order()
            //{
            //    Shipment = new Shipment()
            //    {
            //        Cost = 12f,
            //        ShippingDate = DateTime.Today.AddDays(3)
            //    },
            //    TotalPrice = 14f
            //};

            //orderProcessor.ProcessOrder(order);

            //Console.ForegroundColor = ConsoleColor.Cyan;
            //Console.BackgroundColor = ConsoleColor.DarkRed;
            //var tellyLogger = new TvLogger();
            //Console.WriteLine(tellyLogger.LogInfo("Coucou from the tellyLogger!"));

            //Console.ForegroundColor = ConsoleColor.DarkMagenta;
            //Console.BackgroundColor = ConsoleColor.Yellow;
            //var dbMigrator = new DbMigrator(tellyLogger);
            //Console.WriteLine(dbMigrator.Migrate());

            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Black;
            //var fileLogger = new FileLogger(@"C:\\Users\BIO359\source\repos\log.txt");
            //var anotherDbMigrator = new DbMigrator(fileLogger);
            //Console.WriteLine(anotherDbMigrator.Migrate());

            var video = new Video();
            var encoder = new VideoEncoder();

            // different forms of the same INotificationService = polymorphism
            encoder.RegisterNotificationService(new MailService());
            encoder.RegisterNotificationService(new TextService());
            var message = encoder.Encode(video);
            Console.WriteLine(message);
        }
    }
}
