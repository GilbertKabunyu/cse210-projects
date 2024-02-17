// Savings class

class Savings
{
    public decimal SavingsTarget { get; set; }
    public decimal CurrentSavings { get; set; }

    public Savings(decimal savingsTarget)
    {
        SavingsTarget = savingsTarget;
        CurrentSavings = 0;
    }

    public void TrackSavings(decimal amount)
    {
        CurrentSavings += amount;
    }

    public decimal CalculateProgress()
    {
        return (CurrentSavings / SavingsTarget) * 100;
    }
}