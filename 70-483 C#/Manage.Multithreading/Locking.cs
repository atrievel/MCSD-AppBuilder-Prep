using System;
using System.Threading;
using System.Threading.Tasks;

namespace Manage.Multithreading
{
    internal static class Locking
    {
        private static readonly object _lock = new object();
        private static string owner = "No one";
        internal static void IncrementWithLock()
        {
            for (int i = 1; i <= 10; i++)
            {
                ThreadStart start = new ThreadStart(RunLock);
                Thread current = new Thread(start);
                current.Name = $"Thread {i}";

                current.Start();
            }
        }
        private static void RunLock()
        {
            Console.WriteLine($"{Thread.CurrentThread.Name} is queued to be the owner");

            lock(_lock)
            {
                owner = Thread.CurrentThread.Name;
                Console.WriteLine($"The owner is now {owner}!");
            }
        }
    }
}
