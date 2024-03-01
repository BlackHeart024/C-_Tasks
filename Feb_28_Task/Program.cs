namespace Feb_28_Task;

class DivNumbers
{
    int ans;
    DivNumbers()
    {
        ans = 0;
    }
    public void Division(int n1, int n2)
    {
        try
        {
            ans = n1 / n2;
        }
        catch(DivideByZeroException e)
        {
            Console.WriteLine("Exception caught: {0}",e);
        }
        finally
        {
            Console.WriteLine("Result: {0}",ans);
        }
    }
    static void Main(string[] args)
    {
        DivNumbers obj = new DivNumbers ();
        obj.Division(20, 0);
    }
}