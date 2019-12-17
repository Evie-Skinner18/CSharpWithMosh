using System;

namespace Interfaces.Extensibility
{
    public class DbMigrator
    {
        // DbMigrator doesn't care who the logger is. As long as we get someone: Kudz, Suhejb, Brenda, who can do the logging
        // (like a rstaurant with a chef!), it's happy
        private ILogger _logger { get; set; }

        // dependency injection: inject an ILogger from outside so DB migrator does not depend on a concretion
        // now it depends on an abstraction!
        public DbMigrator(ILogger logger)
        {
            _logger = logger;    
        }

        public string Migrate()
        {
            var startMessage = $"{_logger.LogInfo($"Migration started at {DateTime.Now}")}";
            var endMessage = $"{_logger.LogInfo($"Migration finished at {DateTime.Now}")}";

            return $"{startMessage}\n {endMessage}";
        }
    }
}
