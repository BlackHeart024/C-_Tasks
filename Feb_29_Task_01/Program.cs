namespace Feb_29_Task_01;
class EventsAndDelegates
{
    static void Main(string[] args)
    {
        Methods del1 = new Methods();
        del1.Manager_WorkPerformed(10,WorkType.Golf);
        del1.Manager_WorkPerformed(20,WorkType.GotoMeetings);
        del1.Manager_WorkPerformed(5, WorkType.GenericReports);
        del1.rect_Area(10,20);
    }
}
public enum WorkType
{
    Golf,
    GotoMeetings,
    GenericReports
}
class Methods
{
    public void Manager_WorkPerformed(int workHours, WorkType wType)
    {
        Console.WriteLine("Work Performed by Event Handler");
        Console.WriteLine($"Work hours: {workHours}, Work Type: {wType}");
    }

    public int rect_Area(int l, int b)
    {
        return l*b;
    }
}