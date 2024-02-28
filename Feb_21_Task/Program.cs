using System;

namespace Feb_21_Task;

class Program
{
    static void Main(string[] args)
    {
        int tasks = 0;
        
        while(tasks != 4)
        {
            Console.WriteLine("|------------------List of tasks------------------|");
            Console.WriteLine("|1. Given numbers are equal or not                |");
            Console.WriteLine("|2. Given number is positive or not               |");
            Console.WriteLine("|3. Display day name according to given day number|");
            Console.WriteLine("|4. Exit                                          |");
            Console.WriteLine("|-------------------------------------------------|");
            Console.Write("Enter task number: ");
            tasks = Convert.ToInt32(Console.ReadLine());

            switch(tasks)
            {
            case 1:
                task1();
                break;

            case 2:
                task2();
                break;
            
            case 3:
                task3();
                break;

            case 4:
                Console.WriteLine("|----------Thank you for your patronage-----------|");
                break;

            default:
                Console.WriteLine("Enter a valid task number.");
                break;
            }
        }
    }

    static void task1()
    {
        Console.WriteLine("Check whether given two numbers are equal or not");
        int a;
        Console.Write("Enter first number: ");
        a = Convert.ToInt32(Console.ReadLine());

        int b;
        Console.Write("Enter second number: ");
        b = Convert.ToInt32(Console.ReadLine());
                
        if(a == b)
            Console.WriteLine(a + " and " + b + " are equal.");
        else
            Console.WriteLine(a + " and " + b + " are not equal.");
        Console.WriteLine("***************************************");
    }

    static void task2()
    {
        Console.WriteLine("Check whether given number is positive or not");
        int m;
        Console.Write("Enter a number: ");
        m = Convert.ToInt32(Console.ReadLine());

        if(m == 0)
            Console.WriteLine(m + " is zero.");
        else if(m > 0)
            Console.WriteLine(m + " is a positive number.");
        else
            Console.WriteLine(m + " is a negative number.");
        Console.WriteLine("***************************************");
    }

    enum Days 
        {
            Monday = 1,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
    static void task3()
    {
        Console.WriteLine("Display day name according the given day number");

        int day;
        Console.Write("Enter day number: ");
        day = Convert.ToInt32(Console.ReadLine());

        switch(day)
        {
            case 1:
                //Console.WriteLine("Monday");
                Console.WriteLine(Days.Monday);
                break;
            case 2:
                //Console.WriteLine("Tuesday");
                Console.WriteLine(Days.Tuesday);
                break;
            case 3:
                //Console.WriteLine("Wednesday");
                Console.WriteLine(Days.Wednesday);
                break;
            case 4:
                //Console.WriteLine("Thursday");
                Console.WriteLine(Days.Thursday);
                break;
            case 5:
                //Console.WriteLine("Friday");
                Console.WriteLine(Days.Friday);
                break;
            case 6:
                //Console.WriteLine("Saturday");
                Console.WriteLine(Days.Saturday);
                break;
            case 7:
                //Console.WriteLine("Sunday");
                Console.WriteLine(Days.Sunday);
                break;
            default:
                //Console.WriteLine("Enter a valid day number.");
                break;
        }
        Console.WriteLine("***************************************");
    }
}
