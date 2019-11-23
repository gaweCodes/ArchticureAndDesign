using System;
using System.Collections.Generic;
using System.Threading;

namespace Singleton
{
    public sealed class PrinterSpooler
    {
        private static readonly PrinterSpooler SharedInstance = new PrinterSpooler();
        private static readonly object LockObj = new object();
        private static bool _available = true;
        private readonly Queue<PrintJob> _printerJobs;

        private class DispsoseHandle : IDisposable
        {
            public void Dispose()
            {
                lock (LockObj)
                {
                    _available = true;
                }
            }
        }
        public IDisposable ResourceHandle => new DispsoseHandle();
        private PrinterSpooler()
        {
            _printerJobs = new Queue<PrintJob>();
        }
        public static bool TryGetInstance(out PrinterSpooler instance)
        {
            lock (LockObj)
            {
                if (_available)
                {
                    _available = false;
                    instance = SharedInstance;
                    return true;
                }
                instance = null;
                return false;
            }
        }
        public void Print(PrintJob job)
        {
            _printerJobs.Enqueue(job);
            new Thread(PrintJobs).Start();
        }

        private void PrintJobs()
        {
            Console.WriteLine(_printerJobs.Dequeue().Message);
        }

    }

    
}
