public class ChecklistGoal : Goal
{
    public int ValuePerCompletion { get; set; }
    public int RequiredCompletions { get; set; }
    public int Completions { get; set; }

    // A constructor that calls the base constructor and initializes the value per completion, required completions, and completions attributes
    public ChecklistGoal(string name, int valuePerCompletion, int requiredCompletions) : base(name)
    {
        ValuePerCompletion = valuePerCompletion;
        RequiredCompletions = requiredCompletions;
        Completions = 0;
    }

    public override void CheckCompletion()
    {
        Completed = Completions >= RequiredCompletions;
    }

    public override int GetPoints()
    {
        int points = ValuePerCompletion * Completions;
        if (Completed)
        {
            points += 500; // Bonus points for achieving the required completions
        }
        return points;
    }

    public override void DisplayStatus()
    {
        string completionStatus = Completed ? $"Completed {Completions}/{RequiredCompletions} times" : "Not completed";
        Console.WriteLine($"{completionStatus} {Name}");
    }
}