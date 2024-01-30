class Entry
{
    public string Prompt { get; set; } // The prompt that was shown to the user
    public string Response { get; set; } // The response that the user entered
    public string Date { get; set; } // The date of the entry

    // A constructor that takes the prompt, response, and date as parameters
    public Entry(string prompt, string response, string date)
    {
        Prompt = prompt;
        Response = response;
        Date = date;
    }

    // A method to display the entry to the console
    public void Display()
    {
        Console.WriteLine($"Prompt: {Prompt}");
        Console.WriteLine($"Response: {Response}");
        Console.WriteLine($"Date: {Date}");
        Console.WriteLine();
    }
}