using System;

namespace Composition
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var logger = new Logger();
            var migrator = new DbMigrator(logger);
            var installer = new Installer(logger);

            migrator.Migrate();
            installer.Install();
        }
    }
}
