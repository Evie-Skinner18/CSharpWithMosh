using System;


namespace EventsAndDelegates
{
    // make a video event args so we can send additional info to the subscribers of the event.
    // now they will know that not only has an event happneed, but it will see a reference to
    // a video that's been encoded
    public class VideoEventArgs : EventArgs
    {
        public Video Video { get; set; }

    }

}
