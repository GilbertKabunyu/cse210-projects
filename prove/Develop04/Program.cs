using System;
using System.Collections.Generic;
using System.Threading;
public class Program
{
    public static void Main(string[] args)


    {
        Console.WriteLine("Welcome to the Mindfulness App!");
        Console.WriteLine("Please choose an activity:");
        Console.WriteLine("1. Breathing Activity"); // self control management proccess
        Console.WriteLine("2. Reflection Activity"); // thinking more about the day, how it went
        Console.WriteLine("3. Listing Activity"); // people can learn more about listing 
        Console.WriteLine("4. Meditation Activity"); // hepls people to think more 
        Console.Write("Enter your choice (1-4): ");
        int choice = int.Parse(Console.ReadLine());

        Activity activity;

        switch (choice) // menu for this program
        {
            case 1:
                activity = new BreathingActivity();
                break;
            case 2:
                activity = new ReflectionActivity();
                break;
            case 3:
                activity = new ListingActivity();
                break;
            case 4:
                activity = new MeditationActivity();
                break;
            default:
                Console.WriteLine("Invalid choice. Exiting program.");
                return;
        }

        activity.Start();

        if (activity is BreathingActivity breathingActivity)
        {
            breathingActivity.PerformBreathing();
        }
        else if (activity is ReflectionActivity reflectionActivity)
        {
            reflectionActivity.PerformReflection();
        }
        else if (activity is ListingActivity listingActivity)
        {
            listingActivity.PerformListing();
        }
        else if (activity is MeditationActivity meditationActivity)
        {
            meditationActivity.PerformMeditation();
        }

        activity.End();


        Console.WriteLine("Thank you for using the Mindfulness App!");
    }
}