public class MeditationActivity : Activity
{
    public override void Start()
    {
        Console.WriteLine("Meditation Activity starting...");
        Console.WriteLine("Find a comfortable and quiet place to sit. Close your eyes and focus on your breath.");
        Console.Write("Enter the duration in seconds: ");
        duration = int.Parse(Console.ReadLine());
        base.Start();
    }

    public override void End()
    {
        base.End();
    }

    public void PerformMeditation()
    {
        Console.WriteLine("Focus on your breath...");
        Thread.Sleep(duration * 1000);
    }
}