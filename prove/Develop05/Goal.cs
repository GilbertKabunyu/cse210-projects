public class Goal
{
    public string Name { get; set; }
    public bool Completed { get; set; }

    // A constructor that initializes the name and completed attributes
    public Goal(string name)
    {
        Name = name;
        Completed = false;
    }

    public virtual void CheckCompletion()
    {
        // Check if the goal has been completed
    }

    public virtual int GetPoints()
    {
        return 0;
    }

    public virtual void DisplayStatus()
    {
        string completionStatus = Completed ? "[X]" : "[ ]";
        Console.WriteLine($"{completionStatus} {Name}");
    }
}