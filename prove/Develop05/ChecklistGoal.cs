public class ChecklistGoal : Goal
{
    private int targetCount;
    private int completedCount;

    public ChecklistGoal(string description, int value, int targetCount) : base(description, value)
    {
        this.targetCount = targetCount;
    }

    public override void RecordEvent()
    {
        base.RecordEvent();
        completedCount++;
        Console.WriteLine($"Checklist goal event recorded! Completed {completedCount}/{targetCount} times");
    }

    public override void DisplayProgress()
    {
        base.DisplayProgress();
    }
}