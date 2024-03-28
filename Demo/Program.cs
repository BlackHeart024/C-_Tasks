using System;
namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            B b = new B();
            b.Get_Details();
            b.Display();
        }
    }
    public interface IA
    {
        public int num1 { get ; set; }
        public string name1 { get ; set; } 
    }
    public class A : IA
    {
        public int num1 { 
                            get { return num1; }
                            set { num1 = value; }
                        }
        public string name1 { 
                                get { return name1; }
                                set { name1 = value; }
                            }
        public void Get_Details()
        {
            Console.Write("Enter your number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter your name: ");
            name1 = Console.ReadLine();
        }
    }
    public class B : A
    {
        public void Display()
        {
            Console.WriteLine($"{num1} {name1}");
        }
    }
}