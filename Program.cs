using System;
using System.Threading;

namespace r_ctrl_c
{
    class Program
    {
        static void Main(string[] args)
        {
            var stop = new ManualResetEvent(false);

            Console.CancelKeyPress += (s, e) =>
            {
                Console.WriteLine("CTRL-C!");
                stop.Set();
                e.Cancel = true; // we'll handle outselves for this demo
            };

            //RDotNet.REngine.GetInstance();

            Console.WriteLine("Started...");
            stop.WaitOne();
            Console.WriteLine("Stopped");
        }
    }
}
