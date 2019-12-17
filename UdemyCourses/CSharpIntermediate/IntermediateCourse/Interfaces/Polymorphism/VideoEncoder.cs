using System.Collections.Generic;

namespace Interfaces.Polymorphism
{
    // this class is OPEN for extension and CLOSED for modification
    // we don't need to change VideoEncoder itself to broaden what it can do
    // we just need to give it different Inotifcation service if we want it to do something different!
    public class VideoEncoder
    {
        private IList<INotificationService> _notificationServices { get; set; }

        public VideoEncoder()
        {
            _notificationServices = new List<INotificationService>();
        }

        
        public string Encode(Video video)
        {
            var allMessages = "";

            foreach (var service in _notificationServices)
                allMessages = $"{allMessages}\n {service.Send(new Message())}";

            return allMessages;
        }

        // lsit of services is private so we use public method to add a service to the list from the outside
        public void RegisterNotificationService(INotificationService service)
        {
            _notificationServices.Add(service);
        }
    }
}
