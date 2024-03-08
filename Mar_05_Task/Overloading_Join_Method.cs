using System.Threading;
using System;

namespace Mar_05_Task
{
    class Overloaded_Join_Method
    {
        public static void Over_Join_Method()
        {
            Console.WriteLine("Main Thread Started");

            //Main Thread creating three child threads
            Thread thread1 = new Thread(Method1);
            Thread thread2 = new Thread(Method2);
            Thread thread3 = new Thread(Method3);

            thread1.Start();
            thread2.Start();
            thread3.Start();
            
            //Now, Main Thread will block for 3 seconds and wait thread2 to complete its execution
            if (thread2.Join(TimeSpan.FromSeconds(3)))
            {
                Console.WriteLine("Thread 2 Execution Completed in 3 second");
            }
            else
            {
                Console.WriteLine("Thread 2 Execution Not Completed in 3 second");
            }

            //Now, Main Thread will block for 3 seconds and wait thread3 to complete its execution
            if (thread3.Join(3000))
            {
                Console.WriteLine("Thread 3 Execution Completed in 3 second");
            }
            else
            {
                Console.WriteLine("Thread 3 Execution Not Completed in 3 second");
            }

            Console.WriteLine("Main Thread Ended");
        }

        static void Method1()
        {
            Console.WriteLine("Method1 - Thread1 Started");
            Thread.Sleep(1000);
            Console.WriteLine("Method1 - Thread 1 Ended");
        }

        static void Method2()
        {
            Console.WriteLine("Method2 - Thread2 Started");
            Thread.Sleep(2000);
            Console.WriteLine("Method2 - Thread2 Ended");
        }

        static void Method3()
        {
            Console.WriteLine("Method3 - Thread3 Started");
            Thread.Sleep(5000);
            Console.WriteLine("Method3 - Thread3 Ended");
        }
    }
}