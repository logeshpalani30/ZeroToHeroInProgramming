using System;

namespace PlayingWithCSharp
{
    // Initialize Test
    // var stopWatch = new StopWatch();
    // stopWatch.Start();
    // Thread.Sleep(2000);
    // stopWatch.Stop();
    // stopWatch.Start();
    // Thread.Sleep(2000);
    // stopWatch.Stop();
    // Console.WriteLine(stopWatch.TotalDuration.TotalMilliseconds);

    public class StopWatch
    {
        private DateTime _startDateTime;
        private bool _isRunning;
        public TimeSpan TotalDuration { get;private set; }

        public void Start()
        {       
            if (_isRunning)
                throw new InvalidOperationException("Stopwatch already running!");

            _startDateTime = DateTime.Now;
            _isRunning = true;
        }

        public void Stop()
        {
            if (!_isRunning)
                throw new InvalidOperationException("Stopwatch not running");

            _isRunning = false;
            TotalDuration += (DateTime.Now-_startDateTime);
        }
    }
}