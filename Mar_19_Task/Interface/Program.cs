// Interface
// Create an interface IInfo with methods Name() and Address().
// Implement this interface in a class Info that calls a class PrintInfo  that prints logs to the console.
// Write a console application to demonstrate the use of interfaces by creating instances of both Info and using them to print information. 
using System;
namespace Interface;

class Program
{
    static void Main(string[] args)
    {   
        Info i = new Info();
        i.result();
    }
}

public interface IInfo
{
    public void Name();
    public void Address();   
}

public class Info : IInfo
{
    public void Name()
    {
        string name = "Chintan";
        System.Console.WriteLine(name);
    }
    public void Address()
    {
        string address = "Valsad";
        System.Console.WriteLine(address);
    }
    public void result()
    {
        PrintInfo pi = new PrintInfo();
        pi.Print();        
    }
}

public class PrintInfo
{
    public void Print()
    {
        Info i = new Info();
        i.Name();
        i.Address();
    }
}