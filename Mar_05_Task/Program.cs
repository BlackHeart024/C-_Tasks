using System.Threading;
using System;

namespace Mar_05_Task;

class ThreadingDemo
{
    static void Main(string[] args)
    {
        Thread t1 = new Thread(DisplayNumbers);
        t1.Start();
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
