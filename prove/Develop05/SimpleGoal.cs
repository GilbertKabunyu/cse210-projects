public class SimpleGoal : Goal
{
    public int Value { get; set; }

    // A constructor that calls the base constructor and initializes the value attribute
    public SimpleGoal(string name, int value) : base(name)
    {
        Value = value;
    }

    public override int GetPoints()
    {
        if (Completed)
        {
            return Value;
        }
        else
        {
            return 0;
        }
    }
}