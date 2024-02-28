using System.Text;

namespace Feb_26_Task;

class Program
{
    static void Main(string[] args)
    {
        int tasks = 0;
        
        while(tasks != 5)
        {
            Console.WriteLine("|------------------------------------------List of tasks-----------------------------------------|");
            Console.WriteLine("|1. Take three letters and display them in reverse order                                         |");
            Console.WriteLine("|2. Take a number and width and display a triangle of that width using that number               |");
            Console.WriteLine("|3. Take user id and password as string input reject the user after three unsuccessful attempts  |");
            Console.WriteLine("|4. Take roll no,name and marks of 3 subjects and calculate total, percentage and division       |");
            Console.WriteLine("|5. Exit                                                                                         |");
            Console.WriteLine("|------------------------------------------------------------------------------------------------|");
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
                Console.WriteLine("|-----------------------------------Thank you for your patronage---------------------------------|");
                break;

            default:
                Console.WriteLine("Enter a valid task number.");
                break;
            }
        }
    }

    static void task1()
    {
        Console.WriteLine("Take three letters and display them in reverse order");
        string? ch1,ch2,ch3;
        Console.Write("Enter letter: ");
        ch1 = Console.ReadLine();
        Console.Write("Enter letter: ");
        ch2 = Console.ReadLine();
        Console.Write("Enter letter: ");
        ch3 = Console.ReadLine();

        StringBuilder sb = new StringBuilder();
        char char1, char2, char3;
        if (char.TryParse(ch3, out char3))
        {
            sb.Append(char3);
            sb.Append(" ");
        }
        if (char.TryParse(ch2, out char2))
        {
            sb.Append(char2);
            sb.Append(" ");
        }
        if (char.TryParse(ch1, out char1))
        {
            sb.Append(char1);
        }

        Console.WriteLine(sb);
        Console.WriteLine("***************************************");
    }

    static void task2()
    {
        Console.WriteLine("Take a number and width and display a triangle of that width using that number");
        int m,n,i,j;
        Console.Write("Enter a number: ");
        m = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the desired width: ");
        n = Convert.ToInt32(Console.ReadLine());

        for(i = n; i >= 1; i--)
        {
            for(j = 1; j <= i; j++)
            {
                Console.Write(m);
            }
            Console.WriteLine("");
        }
        Console.WriteLine("***************************************");
    }

    static void task3()
    {
        Console.WriteLine("Take user id and password as string input reject the user after three unsuccessful attempts");
        
        int attempts = 0;
        int maxAttempts = 3;
        string? uname,upass;
        string actual_Name="chintan", actual_Pass="chin2020";
        
        while(attempts < maxAttempts)
        {
            
            Console.Write("Input a username: ");
            uname = Console.ReadLine();
            Console.Write("Input a password: ");
            upass = Console.ReadLine();

            if(actual_Name == uname && actual_Pass == upass)
            {
                Console.WriteLine("Logged in successful!");
                break;
            }
            else
            {
                attempts++;
                Console.WriteLine("Invalid username or password.");
            }
        }
        if(attempts == maxAttempts)
        {
            Console.WriteLine("Login attempts more than three times. Try again later!");
        }
        Console.WriteLine("***************************************");
    }

    static void task4()
    {
        int rno=0,m1=0,m2=0,m3=0;
        string? name;

        Console.Write("Input the Roll Number of the Student: ");
        rno = Convert.ToInt32(Console.ReadLine());

        Console.Write("Input the Name of the Student: ");
        name = Console.ReadLine();

        Console.Write("Input the marks of Physics: ");
        m1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Input the marks of Chemistry: ");
        m2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Input the marks of Computer Applications: ");
        m3 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Roll no : " + rno);
        Console.WriteLine("Name of the Student: " + name);
        Console.WriteLine("Marks in Physics: " + m1);
        Console.WriteLine("Marks in Chemistry: " + m2);
        Console.WriteLine("Marks in Computer Applications: " + m3);

        int total = m1 + m2 + m3;
        Console.WriteLine("Total marks = " + total);

        double per = total / 3;
        Console.WriteLine("Percentage = " + per);

        if(per <= 100 && per >= 60)
        {
            Console.WriteLine("Division: First class");
        }
        else if(per < 60 && per >=50)
        {
            Console.WriteLine("Division: Second class");
        }
        else if(per < 50 && per >= 30)
        {
            Console.WriteLine("Division: Third class");
        }
        else
        {
            Console.WriteLine("Fail");
        }
        Console.WriteLine("***************************************");
    }
}