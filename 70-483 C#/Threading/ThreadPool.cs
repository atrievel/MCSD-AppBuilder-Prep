using System;
using System.Threading;

/// <summary>
/// Code referenced from https://docs.microsoft.com/en-us/dotnet/api/system.threading.threadpool?view=netframework-4.8
/// </summary>
public class ThreadPool
{
    public static void Main()
    {
        // Queue the task.
        ThreadPool.QueueUserWorkItem(ThreadProc);
        Console.WriteLine("Main thread does some work, then sleeps.");
        Thread.Sleep(1000);

        Console.WriteLine("Main thread exits.");
    }

    // This thread procedure performs the task.
    static void ThreadProc(Object stateInfo)
    {
        // No state object was passed to QueueUserWorkItem, so stateInfo is null.
        Console.WriteLine("Hello from the thread pool.");
    }
}
// The example displays output like the following:
//       Main thread does some work, then sleeps.
//       Hello from the thread pool.
//       Main thread exits.