using System;

namespace Stopwatch
{
    public class Stopwatch
    {
        private DateTime _startTime { get; set; }
        private DateTime _stopTime { get; set; }
        private DateTime _duration { get; set; }

        public Stopwatch()
        {

        }

        public TimeSpan Start()
        {
            return DateTime.Now.TimeOfDay;            
        }

        public TimeSpan Stop()
        {
            return DateTime.Now.TimeOfDay;
        }
            
    }
}
