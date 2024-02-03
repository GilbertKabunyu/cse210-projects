public abstract class Activity
{
    protected int duration;

    public Activity()
    {
        duration = 0;
    }

    public virtual void Start()
    {
        Console.WriteLine("Activity starting...");
        Console.WriteLine("Prepare to begin...");
        Thread.Sleep(3000);
    }

    public virtual void End()
    {
        Console.WriteLine("Activity ending...");
        Console.WriteLine("Good job!");
        Console.WriteLine($"Activity completed in {duration} seconds.");
        Thread.Sleep(3000);
    }
}