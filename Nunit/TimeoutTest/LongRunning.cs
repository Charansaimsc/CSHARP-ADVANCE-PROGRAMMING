/*Create a method LongRunningTask() that sleeps for 3 seconds before returning
a result.
Use NUnit [Timeout(2000)] or MSTest [Timeout(2000)] to fail the test if the
method takes more than 2 seconds*/

using System;
using System.Threading;

public class TaskRunner
{
    public string LongRunningTask()
    {
        Thread.Sleep(100);
        return "Completed";
    }
}

