using System;
using System.Collections.Generic
class Program
{
    static void Main(string[] args)
    {
        List<Scripture> scriptures = new List<Scripture>();
        scriptures.Add(new Scripture("John 3:16", "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life."));
        scriptures.Add(new Scripture("Proverbs 3:5-6", "Trust in the LORD with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight."));

        Console.Clear();

        foreach (Scripture scripture in scriptures)
        {
            scripture.DisplayScripture();
            Console.WriteLine();
        }

        while (true)
        {
            Console.WriteLine("Press enter to hide a word or type quit to exit:");
            string userInput = Console.ReadLine();

            if (userInput.ToLower() == "quit")
            {
                break;
            }
            else
            {
                Console.Clear();
                foreach (Scripture scripture in scriptures)
                {
                    scripture.HideWord();
                    scripture.DisplayScripture();
                    Console.WriteLine();
                }

                if (AllWordsHidden(scriptures))
                {
                    Console.WriteLine("Congratulations, you have memorized all the scriptures!");
                    break;
                }
            }
        }
    }

    static bool AllWordsHidden(List<Scripture> scriptures)
    {
        foreach (Scripture scripture in scriptures)
        {
            if (!scripture.AllWordsHidden())
            {
                return false;
            }
        }
        return true;
    }
}

   