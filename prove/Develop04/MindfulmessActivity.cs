class MindfulnessActivity
{
    protected string name;
    protected string description;
    protected int duration;

    public MindfulnessActivity(string name, string description)
    {
        this.name = name;
        this.description = description;
    }

    public void Start()
    {
        Console.WriteLine($"Starting {name} activity: {description}");
        Console.Write("Enter duration in seconds: ");
        duration = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Prepare to begin...");
        Thread.Sleep(3000); 
    }

    public void End()
    {
        Console.WriteLine($"Good job! You completed the {name} activity for {duration} seconds.");
        Thread.Sleep(3000); 
    }
}