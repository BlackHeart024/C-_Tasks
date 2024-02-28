namespace task_1_20_Feb;

class TypeCasting
{
    static void Main(string[] args)
    {
        // Implicit Type Casting

        int numInt1 = 1500;
        Type numIntType = numInt1.GetType();

        double numDouble1 = numInt1;
        Type numDoubleType = numDouble1.GetType();

        float numFloat1 = numInt1;
        Type numFloatType = numFloat1.GetType();
        
        long numLong1 = numInt1;
        Type numLongType = numLong1.GetType();

        Console.WriteLine($"numInt value: {numInt1}");
        Console.WriteLine($"numInt type: {numIntType}");
        Console.WriteLine($"numInt size: {sizeof(int)} Bytes");

        Console.WriteLine($"numDouble value: {numDouble1}");
        Console.WriteLine($"numDouble type: {numDoubleType}");
        Console.WriteLine($"numDouble size: {sizeof(double)} Bytes");

        Console.WriteLine($"numFloat value: {numFloat1}");
        Console.WriteLine($"numFloat type: {numFloatType}");
        Console.WriteLine($"numFloat size: {sizeof(float)} Bytes");

        Console.WriteLine($"numLong value: {numLong1}");
        Console.WriteLine($"numLong type: {numLongType}");
        Console.WriteLine($"numLong size: {sizeof(long)} Bytes");

        Console.WriteLine("------------------------------------------------");

        // Explicit Type Casting

        double numDouble2 = 2.24;
        int numInt2 = (int)numDouble2;
        Console.WriteLine("Original double Value: " + numDouble2);
        Console.WriteLine("Converted int value: " + numInt2);

        float numFloat2 = 2.3f;
        numInt2 = (int)numFloat2;
        Console.WriteLine("Original float Value: " + numFloat2);
        Console.WriteLine("Converted int value: " + numInt2);

    }
}
