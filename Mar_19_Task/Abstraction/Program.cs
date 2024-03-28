// Abstract :
//  Use abstraction to override a method to print Birds that can fly and birds that cannot.

namespace Abstraction;

class Program
{
    static void Main(string[] args)
    {
        Flying_Birds fb = new Flying_Birds();
        Not_Flying_Birds nfb = new Not_Flying_Birds();
        var Flying_Birds = fb.Birds_Name();
        var Not_Flying_Birds = nfb.Birds_Name();
        System.Console.WriteLine("List of flying birds: ");
        foreach(string bird in Flying_Birds)
        {
            System.Console.WriteLine(bird);
        }
        System.Console.WriteLine("List of not flying birds: ");
        foreach(string bird in Not_Flying_Birds)
        {
            System.Console.WriteLine(bird);
        }
    }
}

public abstract class Birds
{
    public abstract  List<string> Birds_Name();
}

public class Flying_Birds : Birds
{
    public override List<string> Birds_Name()
    {
        List<string> fly = new List<string> {
            "Crow",
            "Sparrow",
            "Pegion"
        };
        return fly;
    }
}

public class Not_Flying_Birds : Birds
{
    public override List<string> Birds_Name()
    {
        List<string> not_fly = new List<string> {
            "Penguin",
            "Ostrich",
            "Hen"
        };
        return not_fly;
    }
}