using System;

namespace EventsAndDelegates
{
    public class MessageService
    {
        public void OnVideoEncoded(object source, EventArgs args)
        {
            Console.WriteLine("We are in MessageService. Sending a text...");
        }
    }
}
