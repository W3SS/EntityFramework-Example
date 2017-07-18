using System;
using System.Threading;

namespace EfTUtorial.Utils
{
    class LockUtil : IDisposable
    {
        private readonly object _lockObj;

        public LockUtil(object lockObj) : this(lockObj, TimeSpan.FromSeconds(8)) { }

        private LockUtil(object lockObj, TimeSpan timeout)
        {
            _lockObj = lockObj;
            if (!Monitor.TryEnter(_lockObj, timeout))
                throw new TimeoutException();
        }

        public void Dispose()
        {
            Monitor.Exit(_lockObj);
        }
    }
}