public class SimpleGoal : Goal
{
    public SimpleGoal(string description, int value) : base(description, value) { }

    public override void RecordEvent()
    {
        base.RecordEvent();
        Console.WriteLine("Simple goal event recorded!");
    }
}