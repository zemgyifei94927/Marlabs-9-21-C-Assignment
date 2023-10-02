using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    
    internal class BackGroundThreads
    {   
        static void work()
        {
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(100);
                Console.WriteLine("Background thread running...");
            }
        }
        //static void Main()
        //{
        //    var t = new Thread(work);
        //    // Setting the thread to be background thread.
        //    t.IsBackground = true;
        //    t.Start();


        //    for (int i = 0; i < 2; i++)
        //    {
        //        Thread.Sleep(200);
        //        Console.WriteLine("Main thread running...");

        //    }
        //}
    }
}

