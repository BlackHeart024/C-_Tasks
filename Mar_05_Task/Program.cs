using System.Threading;
using System;

namespace Mar_05_Task;

class ThreadingDemo
{
    static void Main(string[] args)
    {
        Thread Main_Thread = new Thread(Main_Program);
        Main_Thread.Start();
        static void Main_Program()
        {
            int tasks = 0;
        
            while(tasks != 6)
            {
                Console.WriteLine("|------------------List of tasks------------------|");
                Console.WriteLine("|1. Single Thread                                 |");
                Console.WriteLine("|2. Multiple Thread                               |");
                Console.WriteLine("|3. Join Method                                   |");
                Console.WriteLine("|4. Overloading Join Method                       |");
                Console.WriteLine("|5. IsAlive Method                                |");
                Console.WriteLine("|6. Exit                                          |");
                Console.WriteLine("|-------------------------------------------------|");
                Console.Write("Enter task number: ");
                tasks = Convert.ToInt32(Console.ReadLine());

                switch(tasks)
                {
                case 1:
                    SingleThread.S_Thread();
                    break;

                case 2:
                    MultiThread.M_Thread();
                    break;
            
                case 3:
                    JoinMethod.J_Method();
                    break;

                case 4:
                    Overloaded_Join_Method.Over_Join_Method();
                    break;

                case 5:
                    IsAlive.IsAlive_Method();
                    break;

                case 6:
                    Console.WriteLine("|----------Thank you for your patronage-----------|");
                    break;

                default:
                    Console.WriteLine("Enter a valid task number.");
                    break;
                }
            }
        }
    }
}
