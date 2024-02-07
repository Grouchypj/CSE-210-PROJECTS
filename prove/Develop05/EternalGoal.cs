public class EternalGoal : Goal
{
    public EternalGoal(string description, int value) : base(description, value) { }

    public override void RecordEvent()
    {
        base.RecordEvent();
        Console.WriteLine("Eternal goal event recorded!");
    }
}