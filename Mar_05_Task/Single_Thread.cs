using System.Threading;
using System;

namespace Mar_05_Task;

class SingleThread
{
    public static void S_Thread()
    {
        Thread t1 = new Thread(DisplayNumbers);
        t1.Start();
        t1.Join();
    }
    static void DisplayNumbers()
    {
        for(int i=1; i<=5; i++)
        {
            Console.WriteLine(i);
            Thread.Sleep(5000);
        }
        Console.WriteLine("Thread Closed");
    }
}
