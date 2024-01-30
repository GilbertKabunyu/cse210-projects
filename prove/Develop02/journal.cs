class Journal
{
    public List<Entry> Entries { get; set; } // A list of entries in the journal
    public List<string> Prompts { get; set; } // A list of prompts to choose from

    // A constructor that initializes the entries and prompts lists
    public Journal()
    {
        Entries = new List<Entry>();
        Prompts = new List<string>()
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            // Add more prompts here
        };
    }

    // A method to write a new entry to the journal
    public void WriteEntry()
    {
        // Pick a random prompt from the list
        Random random = new Random();
        int index = random.Next(Prompts.Count);
        string prompt = Prompts[index];

        // Show the prompt to the user and get their response
        Console.WriteLine(prompt);
        string response = Console.ReadLine();

        // Get the current date as a string
        string date = DateTime.Now.ToString("yyyy-MM-dd");

        // Create a new entry object with the prompt, response, and date
        Entry entry = new Entry(prompt, response, date);

        // Add the entry to the list of entries
        Entries.Add(entry);

        // Display a confirmation message
        Console.WriteLine("Your entry has been saved.");
        Console.WriteLine();
    }

    // A method to display the journal to the console
    public void DisplayJournal()
    {
        // Check if the journal is empty
        if (Entries.Count == 0)
        {
            // Display a message that there are no entries
            Console.WriteLine("Your journal is empty.");
            Console.WriteLine();
        }
        else
        {
            // Loop through the entries and display each one
            Console.WriteLine("Your journal entries:");
            Console.WriteLine();
            foreach (Entry entry in Entries)
            {
                entry.Display();
            }
        }
    }

    // A method to save the journal to a file
    public void SaveJournal()
    {
        // Prompt the user for a filename
        Console.WriteLine("Enter a filename to save your journal:");
        string filename = Console.ReadLine();

        // Create a StreamWriter object to write to the file
        StreamWriter writer = new StreamWriter(filename);

        // Loop through the entries and write each one to the file
        foreach (Entry entry in Entries)
        {
            // Use a separator symbol to separate the fields of the entry
            string separator = "~|~";
            writer.WriteLine(entry.Prompt + separator + entry.Response + separator + entry.Date);
        }

        // Close the writer
        writer.Close();

        // Display a confirmation message
        Console.WriteLine($"Your journal has been saved to {filename}.");
        Console.WriteLine();
    }

    // A method to load the journal from a file
    public void LoadJournal()
    {
        // Prompt the user for a filename
        Console.WriteLine("Enter a filename to load your journal:");
        string filename = Console.ReadLine();

        // Check if the file exists
        if (File.Exists(filename))
        {
            // Create a StreamReader object to read from the file
            StreamReader reader = new StreamReader(filename);

            // Clear the current list of entries
            Entries.Clear();

            // Loop through the lines in the file and create entry objects
            while (!reader.EndOfStream)
            {
                // Read a line from the file
                string line = reader.ReadLine();

                // Split the line by the separator symbol to get the fields of the entry
                string separator = "~|~";
                string[] fields = line.Split(separator);

                // Create a new entry object with the fields
                Entry entry = new Entry(fields[0], fields[1], fields[2]);

                // Add the entry to the list of entries
                Entries.Add(entry);
            }

            // Close the reader
            reader.Close();

            // Display a confirmation message
            Console.WriteLine($"Your journal has been loaded from {filename}.");
            Console.WriteLine();
        }
        else
        {
            // Display an error message that the file does not exist
            Console.WriteLine($"The file {filename} does not exist.");
            Console.WriteLine();
        }
    }

    // A method to provide a menu that allows the user to choose the options
    public void ShowMenu()
    {
        // Display the menu options
        Console.WriteLine("Choose an option:");
        Console.WriteLine("1. Write a new entry");
        Console.WriteLine("2. Display the journal");
        Console.WriteLine("3. Save the journal to a file");
        Console.WriteLine("4. Load the journal from a file");
        Console.WriteLine("5. Exit");

        // Get the user's choice
        string choice = Console.ReadLine();

        // Perform the corresponding action based on the choice
        switch (choice)
        {
            case "1":
                WriteEntry();
                break;
            case "2":
                DisplayJournal();
                break;
            case "3":
                SaveJournal();
                break;
            case "4":
                LoadJournal();
                break;
            case "5":
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Invalid option.");
                Console.WriteLine();
                break;
        }

        // Show the menu again
        ShowMenu();
    }
}