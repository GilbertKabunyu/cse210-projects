public class EternalGoal : Goal
{
    public int Value { get; set; }

    // A constructor that calls the base constructor and initializes the value attribute
    public EternalGoal(string name, int value) : base(name)
    {
        Value = value;
    }

    public override int GetPoints()
    {
        return Value;
    }
}