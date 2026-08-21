using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace UnitTesting.Classes
{
    public class PerformanceTester
    {
        public string LongRunningTask()
        {
            Thread.Sleep(3000);

            return "Task Completed";
        }
    }
}
