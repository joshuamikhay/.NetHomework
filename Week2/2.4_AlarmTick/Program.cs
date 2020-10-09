using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//2018326660145
//Joshua Mikhay Kusuma
namespace _2._4_AlarmTick
{

    // Declare 2 Items Delegation
    public delegate void RingHandler(object sender, string message);
    public delegate void ClockRunHandler(object sender, string time);

    class Clock
    {
        public event RingHandler onRinging;
        public event ClockRunHandler onRunning;

        public void Ring(string message)
        {
            Console.WriteLine(message);
            string messageToHandle = message;
            onRinging(this, messageToHandle);
        }

        public void Run(string time)
        {
            Console.WriteLine($"Local Time >> {time}");
            string timeToHandle = time;
            onRunning(this, timeToHandle);
        }
    }

    class callable
    {
        public Clock clock = new Clock();


        public callable()
        {
            clock.onRinging += new RingHandler(Ring);
            clock.onRunning += new ClockRunHandler(Run);
        }

        void Ring(object sender, string message)
        {
            Console.WriteLine("The Clock will be Ringing Soon...");
        }

        void Run(object sender, string time)
        {
            Console.WriteLine("The Time is going to change...");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            callable call = new callable();
            string time = DateTime.Now.ToLongTimeString().ToString();
            call.clock.Run(time);
            string message = "This is it! The time has come!";
            call.clock.Ring(message);
        }
    }
}

