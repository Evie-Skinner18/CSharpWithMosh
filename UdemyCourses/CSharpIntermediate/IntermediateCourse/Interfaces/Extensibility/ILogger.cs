namespace Interfaces.Extensibility
{
    public interface ILogger
    {
        string LogError(string message);
        string LogInfo(string message);
    }
}
