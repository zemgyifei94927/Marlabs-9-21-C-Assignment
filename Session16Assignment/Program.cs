namespace Session16Assignment
{
    internal class InterThreadCommunication
    {
        static readonly object _lockObject = new object();
        static void ThreadTwoWork() { 
            Monitor.Enter(_lockObject);
            for (int i = 0; i <= 20; i += 2) {
                Console.WriteLine($"It is thread ###TWO### doing the job {i} right now.");
                Monitor.Pulse(_lockObject);
                if (i != 20) {
                    Monitor.Wait(_lockObject);
                }
            }
            Monitor.Exit(_lockObject);
        }

        static void ThreadOneWork()
        {
            Monitor.Enter(_lockObject);
            for (int i = 1; i <= 20; i += 2)
            {
                Console.WriteLine($"It is thread $$$One$$$ doing the job {i} right now.");
                Monitor.Pulse(_lockObject);
                if (i != 19)
                {
                    Monitor.Wait(_lockObject);
                }
            }
            Monitor.Exit(_lockObject);
        }
        //static void Main(string[] args)
        //{
        //    Thread ThreadTwo = new Thread(ThreadTwoWork);
        //    Thread ThreadOne = new Thread(ThreadOneWork);

        //    ThreadTwo.Start();
        //    Thread.Sleep(500);
        //    ThreadOne.Start();

        //    ThreadTwo.Join();
        //    ThreadOne.Join();

        //    Console.ReadKey();

        //}
    }
}