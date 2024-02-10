public class GoalManager
{
    private List<Goal> goals;
    private int score;

    public GoalManager()
    {
        goals = new List<Goal>();
        score = 0;
    }

    public void AddGoal(Goal goal)
    {
        goals.Add(goal);
    }

    public void RecordCompletion(Goal goal)
    {
        if (!goal.Completed)
        {
            goal.Completed = true;
            score += goal.GetPoints();
        }
    }

    public void DisplayScore()
    {
        Console.WriteLine($"Score: {score}");
    }

    public void DisplayGoals()
    {
        for (int i = 0; i < goals.Count; i++)
        {
            Console.Write($"{i + 1}. ");
            goals[i].DisplayStatus();
        }
    }

    // A method that allows the user to choose a goal from the list and record its completion
    public void ChooseGoal()
    {
        Console.WriteLine("Choose a goal to record its completion:");
        DisplayGoals();
        Console.Write("Enter the number of the goal: ");
        int choice = int.Parse(Console.ReadLine());
        if (choice > 0 && choice <= goals.Count)
        {
            Goal goal = goals[choice - 1];
            RecordCompletion(goal);
            Console.WriteLine("You have recorded the completion of the goal!");
        }
        else
        {
            Console.WriteLine("Invalid choice. Please try again.");
        }
    }
}