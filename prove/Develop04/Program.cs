class Program
{
    static void Main()
    {
        Console.WriteLine("Mindfulness Program");

        BreathingActivity breathingActivity = new BreathingActivity();
        ReflectionActivity reflectionActivity = new ReflectionActivity();
        ListingActivity listingActivity = new ListingActivity();

        Console.WriteLine("1. Breathing Activity");
        Console.WriteLine("2. Reflection Activity");
        Console.WriteLine("3. Listing Activity");
        Console.Write("Choose an activity (1-3): ");
        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                breathingActivity.PerformBreathing();
                break;
            case 2:
                reflectionActivity.PerformReflection();
                break;
            case 3:
                listingActivity.PerformListing();
                break;
            default:
                Console.WriteLine("Invalid choice. Exiting program.");
                break;
        }
    }
}