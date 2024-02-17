// Budget class

class Budget
{
    public decimal MonthlyBudget { get; set; }
    public List<Expense> Expenses { get; set; }

    public Budget(decimal monthlyBudget)
    {
        MonthlyBudget = monthlyBudget;
        Expenses = new List<Expense>();
    }

    public void TrackExpense(Expense expense)
    {
        Expenses.Add(expense);
    }

    public decimal CalculateRemainingBudget()
    {
        decimal totalExpenses = 0;
        foreach (var expense in Expenses)
        {
            totalExpenses += expense.Amount;
        }
        return MonthlyBudget - totalExpenses;
    }
}