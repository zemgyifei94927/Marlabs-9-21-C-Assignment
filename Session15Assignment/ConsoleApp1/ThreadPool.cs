using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;

namespace Demo
{
    internal class ThreadPoolDemo
    {
        static void ThreadMethod() { 
            for (int i = 0; i < 10; i++)
            {
                Thread obj = new Thread(Process);
                obj.Start();
            }
        }

        static void ThreadPoolMethod()
        {
            for (int i = 0; i < 10; i++)
            {
                ThreadPool.QueueUserWorkItem(new WaitCallback(Process));
            }
        }
        static void Process(object callback)
        {
            Console.WriteLine("Working...");
        }

        //static void Main()
        //{

        //    Stopwatch sw = new Stopwatch();

        //    Console.WriteLine("ThreadPool Started.");
        //    sw.Start();
        //    ThreadPoolMethod();
        //    sw.Stop();

        //    Thread.Sleep(500);

        //    Console.WriteLine($"Time consumed by Thread pool is {sw.ElapsedTicks.ToString()}");

        //    sw.Reset();

        //    Console.WriteLine("Thread Started.");
        //    sw.Start();
        //    ThreadMethod();
        //    sw.Stop();

        //    Thread.Sleep(500);
        //    Console.WriteLine($"Time consumed by Thread is {sw.ElapsedTicks.ToString()}");
        //}
    }
}
