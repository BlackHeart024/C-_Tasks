// Polymorphism:
// To calculate area of diff shapes like Square, rectangle.

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Square sq = new Square(10,20);
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

        public void area() {}
    }

    public class Square
    {
        public void area()
        {
            System.Console.WriteLine("Area of square: " + l*l);
        }
    }
}