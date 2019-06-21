using System;
using System.Threading;
using System.Threading.Tasks;

namespace Manage.Multithreading
{
    internal static class CancelTask
    {
        internal static void CancelLongRunningTask(int cancelLength)
        {
            CancellationTokenSource tokenSource = new CancellationTokenSource();
            CancellationToken token = tokenSource.Token;
            TaskFactory factory = new TaskFactory(token);

            Task longRunning = Task.Factory.StartNew(() =>
            {
                for (int i = 1; i <= cancelLength*2; i++)
                {
                    Console.WriteLine("Running a new task...");

                    if (i == cancelLength)
                    {
                        tokenSource.Cancel();
                        Console.WriteLine($"Token was canceled before running {i} seconds");
                        break;
                    }

                    if(!token.IsCancellationRequested)
                    {
                        Task.Delay(i*1000);
                        Console.WriteLine($"Task was running for {i} seconds");
                    }
                }
            });

            longRunning.Wait();
        }
    }
}