using System;

namespace EventsAndDelegates
{
    // this will send an email once the video is encoded
    public class MailService
    {
        // this is the event handler
        public void OnVideoEncoded(object source, EventArgs e)
        {
            Console.WriteLine("We arein MailService. Sending an email...");
        }
    }

}
