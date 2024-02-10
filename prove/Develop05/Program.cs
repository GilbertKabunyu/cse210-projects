using System;
using System.Collections.Generic;


public class Program
{
    public static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();

        // Create some goals
        SimpleGoal marathonGoal = new SimpleGoal("Run a marathon", 1000);
        EternalGoal scripturesGoal = new EternalGoal("Read the scriptures", 100);
        ChecklistGoal templeGoal = new ChecklistGoal("Attend the temple", 50, 10);

        // Add goals to the manager
        goalManager.AddGoal(marathonGoal);
        goalManager.AddGoal(scripturesGoal);
        goalManager.AddGoal(templeGoal);

        // A loop that keeps running until the user decides to quit
        bool running = true;
        while (running)
        {
            Console.WriteLine("Welcome to the Eternal Quest program!");
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Choose a goal and record its completion");
            Console.WriteLine("2. Display your goals and score");
            Console.WriteLine("3. Quit the program");
            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    goalManager.ChooseGoal();
                    break;
                case 2:
                    goalManager.DisplayGoals();
                    goalManager.DisplayScore();
                    break;
                case 3:
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
        Console.WriteLine("Thank you for using the Eternal Quest program!");
    }
}

