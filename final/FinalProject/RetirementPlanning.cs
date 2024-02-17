class RetirementPlanning
{
    public int CurrentAge { get; set; }
    public int DesiredRetirementAge { get; set; }
    public decimal ExpectedRetirementIncome { get; set; }
    public decimal RateOfReturn { get; set; }

    public RetirementPlanning(int currentAge, int desiredRetirementAge, decimal expectedRetirementIncome, decimal rateOfReturn)
    {
        CurrentAge = currentAge;
        DesiredRetirementAge = desiredRetirementAge;
        ExpectedRetirementIncome = expectedRetirementIncome;
        RateOfReturn = rateOfReturn;
    }

    public decimal CalculateRetirementSavingsGoal()
    {
        int yearsToRetirement = DesiredRetirementAge - CurrentAge;
        decimal annualSavingsGoal = ExpectedRetirementIncome / RateOfReturn;
        decimal retirementSavingsGoal = yearsToRetirement * annualSavingsGoal;
        return retirementSavingsGoal;
    }

    public decimal TrackRetirementProgress(decimal currentSavings, decimal contributions)
    {
        decimal investmentReturns = currentSavings * RateOfReturn;
        decimal totalSavings = currentSavings + contributions + investmentReturns;
        decimal progress = (totalSavings / CalculateRetirementSavingsGoal()) * 100;
        return progress;
    }

    public List<string> RecommendSavingsStrategies()
    {
        // Provide personalized recommendations based on the user's situation
        List<string> recommendations = new List<string>();
        if (CurrentAge > DesiredRetirementAge)
        {
            recommendations.Add("Consider retiring later.");
        }
        else if (CurrentAge < DesiredRetirementAge)
        {
            recommendations.Add("Increase your contribution amount.");
        }
        return recommendations;
    }
}
