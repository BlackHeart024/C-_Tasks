using System.Text;

namespace Feb_22_Task;

class Program
{
    static void Main(string[] args)
    {
        int tasks = 0;
        
        while(tasks != 7)
        {
            Console.WriteLine("|-------------------------List of tasks--------------------------|");
            Console.WriteLine("|1. Compute the sum of the given digits of an integer            |");
            Console.WriteLine("|2. Fibonacci series                                             |");
            Console.WriteLine("|3. Prime number                                                 |");
            Console.WriteLine("|4. Palindrome number                                            |");
            Console.WriteLine("|5. Factorial number                                             |");
            Console.WriteLine("|6. Armstrong number                                             |");
            Console.WriteLine("|7. Exit                                                         |");
            Console.WriteLine("|----------------------------------------------------------------|");
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
                task4();
                break;

            case 5:
                task5();
                break;

            case 6:
                task6();
                break;

            case 7:
                Console.WriteLine("|--------------------Thank you for your patronage----------------|");

                break;

            default:
                Console.WriteLine("Enter a valid task number.");
                break;
            }
        }
    }

    static void task1()
    {
        Console.WriteLine("Write a C# program and compute the sum of the digits of an integer.");
        int num;
        Console.Write("Input a number(Integer): ");
        num = Convert.ToInt32(Console.ReadLine());

        int sum = 0;
        int tempNum = num;

        while(tempNum != 0)
        {
            int digit = tempNum % 10;
            sum += digit;
            tempNum /= 10;
        }

        Console.WriteLine("Sum of the digits of the said integer: " + sum);

    }

    static void task2()
    {
        Console.WriteLine("Display Fibonacci series");
        
        Console.Write("Input: ");
        int n = Convert.ToInt32(Console.ReadLine());

        StringBuilder s = new StringBuilder();
        s.Append("Fibonacci Series: ");
        for(int i = 0; i < n; i++)
        {
            s.Append(Fibonacci(i));
            s.Append(" ");
        }
        Console.Write(s);
        Console.WriteLine("");

        static int Fibonacci(int n)
        {
            if (n <= 1)
                return n;
            else
                return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }

    static void task3()
    {
        Console.WriteLine("Check if the given integer is Prime or not");

        Console.Write("Input: ");
        int num = Convert.ToInt32(Console.ReadLine());

        if (IsPrime(num))
        {
            Console.WriteLine("Prime number.");
        }
        else
        {
            Console.WriteLine("Not a Prime number.");
        }
    
        Console.WriteLine("");
        
        static bool IsPrime(int number)
        {
            if (number <= 1)
                return false;

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if(number % i == 0)
                    return false;
            }

            return true;
        }
        
    }
    static void task4()
    {
        Console.WriteLine("Display Palindrome numbers");

        Console.Write("Input: ");
        int num = Convert.ToInt32(Console.ReadLine());

        if (IsPalindrome(num))
        {
            Console.WriteLine("Palindrome number.");
        }
        else
        {
            Console.WriteLine("Not a Palindrome number.");
        }
    
        Console.WriteLine("");
        
        static bool IsPalindrome(int number)
        {
            int originalNumber = number;
            int reversedNumber = 0;

            while (number > 0)
            {
                int digit = number % 10;
                reversedNumber = reversedNumber * 10 + digit;
                number /= 10;
            }

            return originalNumber == reversedNumber;
        }
    }

    static void task5()
    {
        Console.WriteLine("Display Factorial numbers");

        Console.Write("Input: ");
        int num = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(Factorial(num));

        static int Factorial(int number)
        {
            if (number == 0)
                return 1;

            else
            {
                return (number * Factorial(number - 1));
            }
        }
    }

    static void task6()
    {
        Console.WriteLine("Display Armstrong numbers");

        Console.Write("Input: ");
        int num = Convert.ToInt32(Console.ReadLine());

        if (IsArmstrong(num))
        {
            Console.WriteLine("Armstrong.");
        }
        else
        {
            Console.WriteLine("Not Armstrong.");
        }

        static bool IsArmstrong(int number)
        {
            int originalNumber = number;
            int numDigits = CountDigits(number);
            int sum = 0;

            while(number > 0)
            {
                int digit = number % 10;
                sum += (int)Math.Pow(digit, numDigits);
                number /=10;
            }
            return sum == originalNumber;
        }

        static int CountDigits(int number)
        {
            int count = 0;
            while(number != 0)
            {
                count++;
                number /= 10;
            }
            return count;
        }
    }
}
