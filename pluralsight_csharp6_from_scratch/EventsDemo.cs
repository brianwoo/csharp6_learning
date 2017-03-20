using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EventsDemo
{
    class Clock
    {
        private int hour;
        private int minute;
        private int second;

        public delegate void SecondChangedHandler(object clock, TimeInfoEventArgs e);

        public event SecondChangedHandler SecondChanged;

        public void Run()
        {
            Console.WriteLine("Clock RUN");

            for (;;)
            {
                Thread.Sleep(100);
                DateTime now = DateTime.Now;
                if (now.Second != second)
                {
                    TimeInfoEventArgs timeInfoEventArgs = 
                        new TimeInfoEventArgs(now.Hour, now.Minute, now.Second);

                    if (SecondChanged != null)
                    {
                        SecondChanged(this, timeInfoEventArgs);
                    }
                }
            }
        }

    }


    class DigitalClock
    {
        public void Subscribe(Clock theClock)
        {
            Console.WriteLine("DigitalClock subscribe");
            theClock.SecondChanged += NewTime;
        }

        public void NewTime(object o, TimeInfoEventArgs e)
        {
            Console.WriteLine($"CurrentTime: " +
                $"{e.Hour.ToString()} " +
                $"{e.Minute.ToString()} " +
                $"{e.Second.ToString()}");
        }
    }


    class Log
    {
        public void Subscribe(Clock theClock)
        {
            Console.WriteLine("Log subscribe");
            theClock.SecondChanged += LogTime;
        }

        public void LogTime(object o, TimeInfoEventArgs e)
        {
            Console.WriteLine($"Logging: " +
                $"{e.Hour.ToString()} " +
                $"{e.Minute.ToString()} " +
                $"{e.Second.ToString()}");
        }
    }

    class Worker
    {
        public static void Main(string[] args)
        {
            Clock clock = new Clock();
            DigitalClock dClock = new DigitalClock();

            dClock.Subscribe(clock);

            Log log = new Log();
            log.Subscribe(clock);

            clock.Run();
        }
    }

    class TimeInfoEventArgs
    {
        public int Hour { get; set; }
        public int Minute { get; set; }
        public int Second { get; set; }

        public TimeInfoEventArgs(int hour, int minute, int second)
        {
            Hour = hour;
            Minute = minute;
            Second = second;
        }

    }

}
