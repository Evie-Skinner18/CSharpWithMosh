using System;
using System.Threading;


namespace EventsAndDelegates
{
    public class VideoEncoder
    {
        public void Encode(Video video)
        {
            Console.WriteLine("Encoding video...");
            Thread.Sleep(3000);
        }
    }

}
