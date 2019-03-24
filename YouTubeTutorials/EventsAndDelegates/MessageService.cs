using System;

namespace EventsAndDelegates
{
    public class MessageService
    {
        public void OnVideoEncoded(object source, VideoEventArgs args)
        {
            Console.WriteLine("MessageService has been notified of the event. " +
                              "Sending a text..." + args.Video.Title);
        }
    }
}
