namespace Feb_29_Task;

public delegate void WorkPerformedHandler(int hours, WorkType workType);
class EventsAndDelegates
{
    static void Main(string[] args)
    {
        WorkPerformedHandler del1 = new WorkPerformedHandler(Manager_WorkPerformed);
        del1+=Manager_complete;
        del1(10,WorkType.Golf);
        del1(20,WorkType.GotoMeetings);
        del1(5, WorkType.GenericReports);
    }

    public static void Manager_WorkPerformed(int workHours, WorkType wType)
    {
        Console.WriteLine("Work Performed by Event Handler");
        Console.WriteLine($"Work hours: {workHours}, Work Type: {wType}");
    }
    public static void Manager_complete(int workHours, WorkType wType)
    {
        Console.WriteLine("Work completd");
    }

}

public enum WorkType
{
    Golf,
    GotoMeetings,
    GenericReports
}