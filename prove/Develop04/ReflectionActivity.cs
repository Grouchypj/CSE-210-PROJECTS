class ReflectionActivity : MindfulnessActivity
{
    private string[] prompts = {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    public ReflectionActivity() : base("Reflection", "Helps you reflect on times of strength and resilience")
    {
    }

    public void PerformReflection()
    {
        Start();

        Random random = new Random();

        for (int i = 0; i < duration; i++)
        {
            string prompt = prompts[random.Next(prompts.Length)];
            Console.WriteLine(prompt);

        
            Console.Write("Reflecting ");
            for (int j = 0; j < 3; j++)
            {
                Console.Write(".");
                Thread.Sleep(500); 
            }
            Console.WriteLine();

           
            Console.WriteLine("Why was this experience meaningful to you?");
           

            Thread.Sleep(3000); 
        }

        End();
    }
}
