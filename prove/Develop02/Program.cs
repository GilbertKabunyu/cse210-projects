using System;
using System.IO;
using System.Collections.Generic;

// The main class of the program
class Program
{
    // The main method of the program
    static void Main(string[] args)
    {
        // Create a new journal object
        Journal journal = new Journal();

        // Show the welcome message
        Console.WriteLine("Welcome to Your Daily Journal!");

        // Show the menu
        journal.ShowMenu();
    }
}