using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace PomodoroTimerApp
{
    internal class Timer
    {
        private readonly int _interval;
        private readonly Timer _timer;

        public event EventHandler TimerFinished;

        public Timer(int interval)
        {
            _interval = interval;
            _timer = new Timer(_interval * 1000);
            _timer.Elapsed += Timer_Elapsed;
        }

        public void Start() => _timer.Start();

        public void Stop() => _timer.Stop();

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            _timer.Stop();
            TimerFinished?.Invoke(this, EventArgs.Empty);
        }
    }
}
