namespace C__Basics;

class CS_Basics
{
    static void Main(string[] args)
    {
        // This is a single line comment
        /*
            This is a multi-line comment
        */

        /*
            int chintan = 23;  // Integer variable
            Console.WriteLine("Hello, World!");
            Console.Write("Hello Chintan");
            Console.WriteLine(" I love c# and the number is " + chintan);
        */

        /*
            Data Types:

            Integer     -  int      -   4 bytes
            Long        -  long     -   8 bytes
            Float       -  float    -   4 bytes
            Double      -  double   -   8 bytes
            Character   -  char     -   2 bytes
            Boolean     -  bool     -   1 bit
            String      -  string   -   2 bytes per character

            int a = 34;
            float b = 34.4f;
            double c = 34.4d;
            bool isGreat = true;
            char d = 'r';
            string e = "this is a string";
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(isGreat);
            Console.WriteLine(d);
            Console.WriteLine(e);
        
        */
        
        /*
            Type Casting

            There are two types of types of type casting
            1. Implicit Casting
                char -> int -> long -> float -> double
            2. Explicit Casting
                
        */ 


        long num;
        num = Convert.ToInt64(Console.ReadLine());
        Console.WriteLine(num);
    }
}
