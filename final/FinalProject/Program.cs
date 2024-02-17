using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Financial Planner!");

        // Get user information
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        Console.Write("Enter your monthly income: ");
        decimal income = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Enter your financial goals: ");
        string financialGoals = Console.ReadLine();

        User user = new User
        {
            Name = name,
            Income = income,
            FinancialGoals = financialGoals
        };

        // Budget setup
        Console.Write("Enter your monthly budget: ");
        decimal monthlyBudget = Convert.ToDecimal(Console.ReadLine());

        Budget budget = new Budget(monthlyBudget);

        // Expense tracking
        Console.Write("Enter the number of expenses: ");
        int expenseCount = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < expenseCount; i++)
        {
            Console.WriteLine($"Enter details for expense {i + 1}:");

            Console.Write("Amount: ");
            decimal amount = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Category: ");
            string category = Console.ReadLine();

            Console.Write("Date (yyyy-MM-dd): ");
            DateTime date = Convert.ToDateTime(Console.ReadLine());

            Expense expense = new Expense
            {
                Amount = amount,
                Category = category,
                Date = date
            };

            budget.TrackExpense(expense);
        }

        // Savings tracking
        Console.Write("Enter your savings target: ");
        decimal savingsTarget = Convert.ToDecimal(Console.ReadLine());

        Savings savings = new Savings(savingsTarget);

        // To-Do list setup
        ToDoList todoList = new ToDoList();

        Console.Write("Enter the number of tasks: ");
        int taskCount = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < taskCount; i++)
        {
            Console.WriteLine($"Enter details for task {i + 1}:");

            Console.Write("Description: ");
            string description = Console.ReadLine();

            Console.Write("Deadline (yyyy-MM-dd): ");
            DateTime deadline = Convert.ToDateTime(Console.ReadLine());

            Task task = new Task
            {
                Description = description,
                Deadline = deadline
            };

            todoList.AddTask(task);
        }

        // Retirement planning
        Console.Write("Enter your current age: ");
        int currentAge = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter your desired retirement age: ");
        int desiredRetirementAge = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter your expected retirement income: ");
        decimal expectedRetirementIncome = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Enter the rate of return (as a decimal): ");
        decimal rateOfReturn = Convert.ToDecimal(Console.ReadLine());

        RetirementPlanning retirementPlanning = new RetirementPlanning(currentAge, desiredRetirementAge, expectedRetirementIncome, rateOfReturn);

        // Notification
        Notification notification = new Notification();
        notification.SendNotification("Approaching budget limit!");

        // Report generation
        Report report = new Report();
        report.GenerateReport(user);

        // Display results
        Console.WriteLine();
        Console.WriteLine("Financial Summary");
        Console.WriteLine("-----------------");
        Console.WriteLine("Budget");
        Console.WriteLine($"Monthly Budget: {budget.MonthlyBudget:C}");
        Console.WriteLine($"Remaining Budget: {budget.CalculateRemainingBudget():C}");
        Console.WriteLine();

        Console.WriteLine("Savings");
        Console.WriteLine($"Savings Target: {savings.SavingsTarget:C}");
        Console.WriteLine($"Current Savings: {savings.CurrentSavings:C}");
        Console.WriteLine($"Savings Progress: {savings.CalculateProgress():F2}%");
        Console.WriteLine();

        Console.WriteLine("To-Do List");
        Console.WriteLine("-----------");
        foreach (var task in todoList.Tasks)
        {
            Console.WriteLine($"Task: {task.Description}");
            Console.WriteLine($"Deadline: {task.Deadline.ToShortDateString()}");
            Console.WriteLine($"Completed: {(task.IsCompleted ? "Yes" : "No")}");
            Console.WriteLine();
        }

        Console.WriteLine("Retirement Planning");
        Console.WriteLine("-------------------");
        Console.WriteLine($"Retirement Savings Goal: {retirementPlanning.CalculateRetirementSavingsGoal():C}");
        Console.WriteLine($"Retirement Progress: {retirementPlanning.TrackRetirementProgress(savings.CurrentSavings, 0):F2}%");
        Console.WriteLine("Recommendations:");
        foreach (var recommendation in retirementPlanning.RecommendSavingsStrategies())
        {
            Console.WriteLine(recommendation);
        }

        Console.ReadLine();
    }
}
