using System;

namespace Mini_Project_on_Classes
{
    /// <summary>
    /// Designing Stopwatch.
    /// </summary>
    /// 

    public class Stopwatch
    {
        // Creating private fields and methods.

        private DateTime _start;
        private DateTime _stop;
        private TimeSpan _timespan;
        private Boolean _running;

        // Creating Start and Stop methods for the Stopwatch.
        public DateTime StartTime()
        {
            // This check to see if the stopwatch is running at the moment.
            if (_running)
                throw new InvalidOperationException("The Stopwatch is running at the moment.");
           
            _start = DateTime.Now;
            _running = true;

            return _start;
        }

        public DateTime StopTime()
        {
            // This check to see if the stopwatch has stopped running.
            if (!_running)
                throw new InvalidOperationException("The Stopwatch is not running at the moment, cannot stop.");
            
            _stop = DateTime.Now;
            _running = false;
            return _stop;
        }

        public TimeSpan StopwatchDuration()
        {
            // This check for the Time Span ran by the stopwatch.

            if (_running)
                return DateTime.Now - _start;
            else
                return _stop - _start;

        }
    }
}
