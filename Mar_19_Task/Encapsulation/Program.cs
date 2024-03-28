// Encapsulation:
// Create a C# class named Shape with private fields for height and width and calculate area.
// Implement encapsulation by providing public methods to set and get these private fields.
// Write a simple console application to demonstrate the use of the Shape class. 

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape sq = new Shape(10,20);
            sq.area();
        }
    }

    public class Shape
    {
        private int length;
        private int height;
        
        public int l { get { return length; } set { length = value; } }
        public int h { get { return height; } set { height = value; } }

        public Shape(int l, int h)
        {
            this.l = l;
            this.h = h;
        }

        public void area()
        {
            System.Console.WriteLine(l*h);
        }
    }
}