namespace Interfaces.Extensibility
{
    public class TvLogger : ILogger
    {
        public string LogError(string message)
        {
            return $"ERROR: {message}";
        }

        public string LogInfo(string message)
        { 
            return $"INFO: {message}";
        }
    }
}
