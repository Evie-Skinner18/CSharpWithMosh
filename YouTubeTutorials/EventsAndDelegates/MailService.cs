using System;

namespace EventsAndDelegates
{
    // this will send an email once the video is encoded
    public class MailService
    {
        // this is the event handler
        public void OnVideoEncoded(object source, VideoEventArgs e)
        {
            Console.WriteLine("MailService has been notified of the event. " +
                              "Sending an email..." + e.Video.Title);
        }
    }
}
