using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_with_event
{
    class Timer
    {
        public delegate void Del();
        public event Del Subscribed;
        public void Subscribe()
        {
            Console.WriteLine("Done.");
            if(Subscribed != null)
                Subscribed();
        }
        public static void Beeping()
        {
            Console.Beep();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Timer t1 = new Timer();
            t1.Subscribed += Timer.Beeping;
            t1.Subscribe();
            t1.Subscribed -= Timer.Beeping;
            Console.ReadKey();
        }
    }
}
