public class BreathingActivity : Activity
{
    public override void Start()
    {
        Console.WriteLine("Breathing Activity starting...");
        Console.WriteLine("This activity will help you relax by guiding you through breathing in and out slowly. Clear your mind and focus on your breathing.");
        Console.Write("Enter the duration in seconds: ");
        duration = int.Parse(Console.ReadLine());
        base.Start();
    }

    public override void End()
    {
        base.End();
    }

    public void PerformBreathing()
    {
        Console.WriteLine("Get ready to start...");
        Thread.Sleep(3000);

        Console.WriteLine("Starting in:");
        for (int i = 3; i > 0; i--)
        {
            Console.WriteLine(i);
            Thread.Sleep(1000);
        }

        Console.WriteLine("Start breathing...");

        for (int i = 0; i < duration; i++)
        {
            Console.WriteLine("Breathe in...");
            Thread.Sleep(1000);
            Console.WriteLine("Breathe out...");
            Thread.Sleep(1000);
        }

        Console.WriteLine("Breathing activity completed.");
    }
}
