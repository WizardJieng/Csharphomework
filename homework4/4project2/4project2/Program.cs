using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4project2
{
    class Program
    {
        static void Main(string[] args)
        {
            ClockForm clockform = new ClockForm();
            DateTime settime = new DateTime(2020,3,13,19,7,0);
            while(true)
            {
                clockform.clock.Start(settime);
                System.Threading.Thread.Sleep(1000);
            }            
        }
    }
    public delegate void ClockElapse(object Sender, EventTime Args);
    public class EventTime:EventArgs
    {
        private DateTime nowtime;
        public DateTime NowTime
        {
            get => nowtime;
            set => nowtime = value;
        }
        private DateTime stoptime;
        public DateTime StopTime
        {
            get => stoptime;
            set => stoptime = value;
        }
    }
    public class Clock
    {
        public event ClockElapse Trick;
        public event ClockElapse Alarm;
        
        public void Start(DateTime TimeRing)
        {
            EventTime time = new EventTime();
            time.NowTime = DateTime.Now;
            time.StopTime = TimeRing;
            if (time.NowTime.ToString() == time.StopTime.ToString())
            {                
                Alarm(this, time);              
            }
            Trick(this, time);
        }
    }
    public class ClockForm
    {
        public Clock clock = new Clock();    
        public ClockForm()
        {
            clock.Trick += new ClockElapse(tick);
            clock.Alarm += new ClockElapse(alarm);
        }
        void tick(object Sender, EventTime Args)
        {
            Console.WriteLine($"现在在嘀嗒，时间为：{DateTime.Now.ToString("F") }");
        }
        void alarm(object Sender, EventTime Args)
        {           
            Console.WriteLine($"到设定时间了！");
        }
    }
}
