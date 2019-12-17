using System.IO;

namespace Interfaces.Extensibility
{
    public class FileLogger : ILogger
    {
        private string _path { get; set; }

        public FileLogger(string filePath)
        {
            _path = filePath;
        }

        public string LogError(string message)
        {
           return Log("ERROR logged to file", message);
        }

        public string LogInfo(string message)
        {
            return Log("INFO logged to file", message);
        }

        private string Log(string message, string messageType)
        {
            using (var writer = new StreamWriter(_path, true))
            {
                writer.WriteLine($"{messageType}: {message}");
            }

            return $"{messageType}: {message}";
        }
    }
}
