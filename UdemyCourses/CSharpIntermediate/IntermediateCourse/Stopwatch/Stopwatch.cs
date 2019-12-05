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

        public DateTime Start()
        {
            _startTime = DateTime.Now;
            return _startTime;
        }

        public TimeSpan Stop()
        {
            _stopTime = DateTime.Now;
            return _stopTime - _startTime;            
        }
    }
}
