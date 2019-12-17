namespace Interfaces.Polymorphism
{
    public class TextService : INotificationService
    {
        public string Send(Message message)
        {
            return "Sending a text...";
        }
    }
}
