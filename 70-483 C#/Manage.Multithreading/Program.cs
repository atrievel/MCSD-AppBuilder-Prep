using System;
using System.Threading.Tasks;

namespace Manage.Multithreading
{
    class Program
    {
        static void Main(string[] args)
        {
            //Locking.IncrementWithLock();
            CancelTask.CancelLongRunningTask(10);
        }
    }
}
