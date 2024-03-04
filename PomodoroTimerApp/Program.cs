using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PomodoroTimerApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Pomodoro Timer!");

                int workMinutes = 25;
                int breakMinutes = 5;

                var pomodoro = new PomodoroTimerApp.Pomodoro(workMinutes, breakMinutes);
                pomodoro.Start();
                Console.WriteLine("Press any key to exit the timer.");
                Console.ReadKey();
            }
        }
    }
}
