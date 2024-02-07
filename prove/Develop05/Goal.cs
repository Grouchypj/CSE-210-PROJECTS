public class Goal
{
    private string description;
    protected int value;

    public Goal(string description, int value)
    {
        this.description = description;
        this.value = value;
    }

    public virtual void RecordEvent()
    {
        Console.WriteLine($"Event recorded for goal: {description}");
    }

    public virtual void DisplayProgress()
    {
        Console.WriteLine($"Progress for goal '{description}': {value} points");
    }
}