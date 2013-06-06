using System;
using System.Timers;

namespace ClassCountdownTimer
{
    public class CountdownTimer
    {
        private readonly Timer _objTimer = new Timer();

        private int _initialMinutes;
        private int _minutes;
        private int _seconds=0;


        public class TickEventArgs : EventArgs
        {
            public int Minutes { get; set; }
            public int Seconds { get; set; }
            public string Display { get; set; }
        }

        public CountdownTimer()
        {
            _objTimer.Interval = 1000;
            _objTimer.Enabled = false;
            _objTimer.Elapsed += new ElapsedEventHandler(objTimer_Elapsed);
        }

        public delegate void TickHandler(object sender, TickEventArgs args);

        public event TickHandler Tick;

        public delegate void CompleteHandler(object sender, EventArgs args);

        public event CompleteHandler Complete;

        public int Minutes
        {
            get
            {
                return _initialMinutes;
            }
            set
            {
                _initialMinutes = value;
                _minutes = value;
                _seconds = 0;
            }
        }

        private void objTimer_Elapsed(object sender, EventArgs args)
        {
            _seconds -= 1;
            if (_seconds < 0)
            {
                _minutes -= 1;
                if (_minutes < 0)
                {
                    StopTimer();
                    _seconds = 0;
                    _minutes = 0;
                    if (Complete != null)
                    {
                        Complete(this, EventArgs.Empty);
                    }
                }
                else
                {
                    _seconds = 59;
                }
            }
            if (Tick != null)
            {
                var myargs = new TickEventArgs
                    {
                        Seconds = _seconds,
                        Minutes = _minutes,
                        Display = _minutes.ToString("00") + ":" + _seconds.ToString("00")
                    };
                Tick(this, myargs);
            }
        }

        public void InitialiseTimer()
        {
            _minutes = _initialMinutes;
            _seconds = 0;
        }
        public void StartTimer()
        {
            _objTimer.Enabled = true; 
            _objTimer.Start();
        }

        public void StopTimer()
        {
            _objTimer.Stop();
        }

        public void ResetTimer()
        {
            _objTimer.Stop();
            _minutes = _initialMinutes;
            _seconds = 0;
        }

        public string GetTime()
        {
            return _minutes.ToString("00") + ":" + _seconds.ToString("00");
        }

    }
}