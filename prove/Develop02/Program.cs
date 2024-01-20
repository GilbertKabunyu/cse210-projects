using System;
using System.IO;
using System.Collections.Generic;

// A class that represents a single journal entry
class Entry
{
    // Properties for the prompt, the response, and the date
    public string Prompt { get; set; }
    public string Response { get; set; }
    public string Date { get; set; }

    // A constructor that takes the prompt, the response, and the date as parameters
    public Entry(string prompt, string response, string date)
    {
        Prompt = prompt;
        Response = response;
        Date = date;
    }

    // A method that returns a string representation of the entry
    public override string ToString()
    {
        return $"Prompt: {Prompt}\nResponse: {Response}\nDate: {Date}\n";
    }
}

// A class that represents the entire journal
class Journal
{
    // A private field for the list of entries
    private List<Entry> entries;

    // A public property that returns the number of entries
    public int Count
    {
        get { return entries.Count; }
    }

    // A constructor that initializes the list of entries
    public Journal()
    {
        entries = new List<Entry>();
    }

    // A method that adds a new entry to the journal
    public void AddEntry(string prompt, string response, string date)
    {
        // Create a new entry object with the given parameters
        Entry entry = new Entry(prompt, response, date);

        // Add the entry to the list
        entries.Add(entry);

        // Display a confirmation message
        Console.WriteLine("Entry added successfully.");
    }

    // A method that displays all the entries in the journal
    public void DisplayJournal()
    {
        // Check if the journal is empty
        if (entries.Count == 0)
        {
            // Display a message
            Console.WriteLine("The journal is empty.");
        }
        else
        {
            // Loop through the list of entries
            for (int i = 0; i < entries.Count; i++)
            {
                // Display the entry number and the entry
                Console.WriteLine($"Entry #{i + 1}");
                Console.WriteLine(entries[i]);
            }
        }
    }

    // A method that saves the journal to a file
    public void SaveJournal(string filename)
    {
        // Check if the journal is empty
        if (entries.Count == 0)
        {
            // Display a message
            Console.WriteLine("The journal is empty.");
        }
        else
        {
            // Create a StreamWriter object to write to the file
            using (StreamWriter writer = new StreamWriter(filename))
            {
                // Loop through the list of entries
                for (int i = 0; i < entries.Count; i++)
                {
                    // Get the entry
                    Entry entry = entries[i];

                    // Escape any commas or quotes in the prompt and the response
                    string prompt = entry.Prompt.Replace("\"", "\"\"");
                    string response = entry.Response.Replace("\"", "\"\"");

                    // Write the entry to the file as a comma-separated line, enclosing the prompt and the response in quotes
                    writer.WriteLine($"\"{prompt}\",\"{response}\",{entry.Date}");
                }
            }

            // Display a confirmation message
            Console.WriteLine($"Journal saved to {filename}.");
        }
    }

    // A method that loads the journal from a file
    public void LoadJournal(string filename)
    {
        // Clear the current list of entries
        entries.Clear();

        // Create a StreamReader object to read from the file
        using (StreamReader reader = new StreamReader(filename))
        {
            // Loop until the end of the file
            while (!reader.EndOfStream)
            {
                // Read a line from the file
                string line = reader.ReadLine();

                // Split the line by commas
                string[] parts = line.Split(',');

                // Get the prompt, the response, and the date from the parts
                string prompt = parts[0].Trim('"');
                string response = parts[1].Trim('"');
                string date = parts[2];

                // Create a new entry object with the parts
                Entry entry = new Entry(prompt, response, date);

                // Add the entry to the list
                entries.Add(entry);
            }
        }

        // Display a confirmation message
        Console.WriteLine($"Journal loaded from {filename}.");
    }

    // A method that edits an existing entry in the journal
    public void EditEntry(int index)
    {
        // Check if the index is valid
        if (index < 0 || index >= entries.Count)
        {
            // Display an error message
            Console.WriteLine("Invalid entry number.");
        }
        else
        {
            // Get the entry
            Entry entry = entries[index];

            // Display the current entry
            Console.WriteLine($"Current entry #{index + 1}");
            Console.WriteLine(entry);

            // Prompt the user for a new response
            Console.WriteLine("Enter a new response (leave blank to keep the current one):");
            string response = Console.ReadLine();

            // Check if the user entered a new response
            if (!string.IsNullOrEmpty(response))
            {
                // Update the entry's response
                entry.Response = response;

                // Display a confirmation message
                Console.WriteLine("Entry updated successfully.");
            }
            else
            {
                // Display a message
                Console.WriteLine("No changes made.");
            }
        }
    }

    // A method that deletes an existing entry from the journal
    public void DeleteEntry(int index)
    {
        // Check if the index is valid
        if (index < 0 || index >= entries.Count)
        {
            // Display an error message
            Console.WriteLine("Invalid entry number.");
        }
        else
        {
            // Remove the entry from the list
            entries.RemoveAt(index);

            // Display a confirmation message
            Console.WriteLine("Entry deleted successfully.");
        }
    }
}

// The main program class
class Program
{
    // A static array of prompts
    static string[] prompts = {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What is something I learned today?",
        "What is something I am grateful for today?",
        "What is something I want to accomplish tomorrow?",
        "What is something I am looking forward to in the near future?",
        "What is something I need to improve on?"
    };

    // A static random number generator
    static Random random = new Random();

    // The main method
    static void Main(string[] args)
    {
        // Create a new journal object
        Journal journal = new Journal();

        // Display a welcome message
        Console.WriteLine("Welcome to the journal program.");

        // Declare a variable for the menu option
        int option = 0;

        // Loop until the user chooses to exit
        while (option != 6)
        {
            // Display the menu
            Console.WriteLine("Please choose an option:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Edit or delete an entry");
            Console.WriteLine("6. Exit");

            // Try to parse the user input as an integer
            if (int.TryParse(Console.ReadLine(), out option))
            {
                // Check the option value
                switch (option)
                {
                    case 1:
                        // Write a new entry
                        WriteNewEntry(journal);
                        break;
                    case 2:
                        // Display the journal
                        journal.DisplayJournal();
                        break;
                    case 3: