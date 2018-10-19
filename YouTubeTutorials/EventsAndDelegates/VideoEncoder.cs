using System;
using System.Threading;


namespace EventsAndDelegates
{
    public class VideoEncoder
    // we want an event in here so that when it's finished envoding, it notifies anyone interested
    // in that event
    {
        // step 1: define a delegate. A delegate determines the signature
        // first param is the class that's publishing the event; second is any additional data we want to send
        // with the event
        //public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);

        // step 2: define an event based on that delegate
        // we don't have to make a custom one as .Net aleady has one! This is exactly
        // equivalent to the delegate above. So we dont have to create a delegate explicitly
        public event EventHandler<VideoEventArgs> VideoEncoded;

        public void Encode(Video video)
        {
            Console.WriteLine("Encoding video...");
            Thread.Sleep(3000);
            Console.WriteLine("Encoding finished!");

            OnVideoEncoded(video);
        }

        // 3: publish the event. Use a method and we call it when the encoder has finished encoding. This will notify
        // all the subscribers
        protected virtual void OnVideoEncoded(Video video)
        {
            // check if there are any subscribers
            if (VideoEncoded !=null)
            {
                // what is publishing the event? The current object: 'this'. Don't want to send additional data this time
                VideoEncoded(this, new VideoEventArgs(){Video = video});
            }
        }
    }

}
