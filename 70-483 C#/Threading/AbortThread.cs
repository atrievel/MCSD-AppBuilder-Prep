using System;
using System.Threading;

namespace MultithreadingApplication
{
    /// <summary>
    /// Code referenced from https://www.tutorialspoint.com/csharp/csharp_multithreading.htm
    /// </summary>
    class ThreadAbortionProgram
    {
        public static void CallToChildThread()
        {
            try
            {
                Console.WriteLine("Child thread starts");

                // Put in some work, like counting to 10
                for (int counter = 0; counter <= 10; counter++)
                {
                    Thread.Sleep(500);
                    Console.WriteLine(counter);
                }

                Console.WriteLine("Child Thread Completed");
            }
            catch (ThreadAbortException e)
            {
                Console.WriteLine("Thread Abort Exception");
            }
            finally
            {
                Console.WriteLine("Couldn't catch the Thread Exception");
            }
        }

        /// <summary>
        /// Create a new worker thread that calls CallToChildThread() then is destroyed after 2 seconds
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            ThreadStart childref = new ThreadStart(CallToChildThread);
            Console.WriteLine("In Main: Creating the Child thread");

            Thread childThread = new Thread(childref);
            childThread.Start();

            //stop the main thread for some time (worker thread will only run for 2 seconds)
            Thread.Sleep(2000);

            //now abort the child 
            Console.WriteLine("In Main: Aborting the Child thread");

            //Destroy Thread
            childThread.Abort();
            Console.ReadKey();
        }
    }
}