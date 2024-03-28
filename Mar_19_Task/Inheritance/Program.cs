// Inheritance:
// Create a base class Animal with a method Sound(). Derive two classes Dog and Cat from Animal.
// Implement the Sound() method in both derived classes to print sounds that the animals make respectively.
// Write a console application to create instances of these Animals and display the sounds they make. 

namespace Inheritance;

class Program
{
    static void Main(string[] args)
    {
        Dog d = new Dog();
        d.Sound();
        Cat c = new Cat();
        c.Sound();
    }
}

public class Animal
{
    public void Sound() {}
}

public class Dog : Animal
{
    public new void Sound()
    {
        Console.WriteLine("Dog Barks.");
    }
}

public class Cat : Animal
{
    public new void Sound()
    {
        Console.WriteLine("Cat Meows.");
    }
}