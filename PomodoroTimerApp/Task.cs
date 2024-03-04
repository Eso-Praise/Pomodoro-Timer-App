using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PomodoroTimerApp
{
    internal class Task
    {
        private readonly Timer _workTimer;
        private readonly Timer _breakTimer;
        private int _completedCycles;

        public Task(int workMinutes, int breakMinutes)
        {
            _workTimer = new Timer(workMinutes);
            _breakTimer = new Timer(breakMinutes);

            _workTimer.TimerFinished += WorkTimerFinished;
            _breakTimer.TimerFinished += BreakTimerFinished;
        }

        public void Start() => _workTimer.Start();

        private void WorkTimerFinished(object sender, EventArgs e)
        {
            Console.WriteLine("Work time is over. Take a break!");
            _breakTimer.Start();
        }

        private void BreakTimerFinished(object sender, EventArgs e)
        {
            _completedCycles++;
            Console.WriteLine($"Break time is over. Completed cycles: {_completedCycles}. Time to work!");
            _workTimer.Start();
        }
    }
}
