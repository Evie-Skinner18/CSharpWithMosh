namespace Interfaces.Polymorphism
{
    public class MailService : INotificationService
    {
        public string Send(Message message)
        {
            return "Sending an email!";
        }
    }
}
