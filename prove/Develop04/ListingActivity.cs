class ListingActivity : MindfulnessActivity
{
    private string[] listingPrompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base("Listing", "Helps you list positive things in your life")
    {
    }

    public void PerformListing()
    {
        Start();

        Random random = new Random();
        string prompt = listingPrompts[random.Next(listingPrompts.Length)];
        Console.WriteLine(prompt);

        Console.Write("You have ");
        for (int i = 1; i <= duration; i++)
        {
            Console.Write(i + " ");
            Thread.Sleep(1000); 
        }
        Console.WriteLine("seconds to list items.");

        
        int itemCount = 0;
        while (true)
        {
            Console.Write("Enter an item (or 'done' to finish): ");
            string input = Console.ReadLine();
            if (input.ToLower() == "done")
                break;
            
            itemCount++;
        }

        Console.WriteLine($"You listed {itemCount} items.");

        End();
    }
}