public class ListingActivity : Activity
{
    private List<string> prompts;

    public ListingActivity()
    {
        prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
    }

    public override void Start()
    {
        Console.WriteLine("Listing Activity starting...");
        Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        Console.Write("Enter the duration in seconds: ");
        duration = int.Parse(Console.ReadLine());
        base.Start();
    }

    public override void End()
    {
        base.End();
    }

    public void PerformListing()
    {
        Random random = new Random();
        string prompt = prompts[random.Next(prompts.Count)];
        Console.WriteLine(prompt);
        Thread.Sleep(3000);

        Console.WriteLine("Start listing items...");
        Console.WriteLine("Press Enter after each item. Enter 'done' to finish.");

        int itemCount = 0;
        string item = Console.ReadLine();

        while (item != "done")
        {
            itemCount++;
            item = Console.ReadLine();
        }

        Console.WriteLine($"Number of items listed: {itemCount}");
    }
}