class BreathingActivity : MindfulnessActivity
{
    public BreathingActivity() : base("Breathing", "Helps you relax by guiding your breathing")
    {
    }

    public void PerformBreathing()
    {
        Start();

        for (int i = 0; i < duration; i++)
        {
            Console.WriteLine((i % 2 == 0) ? "Breathe in..." : "Breathe out...");
            Thread.Sleep(1000); 
        }

        End();
    }
}
