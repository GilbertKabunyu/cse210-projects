class Scripture
{
    public Reference reference;
    public string text;
    public List<Word> hiddenWords;

    public Scripture(string referenceText, string text)
    {
        this.reference = new Reference(referenceText);
        this.text = text;
        this.hiddenWords = new List<Word>();
    }

    public void DisplayScripture()
    {
        reference.DisplayReference();
        string[] words = text.Split(' ');
        foreach (string word in words)
        {
            if (IsWordHidden(word))
            {
                Console.Write("_____ ");
            }
            else
            {
                Console.Write(word + " ");
            }
        }
        Console.WriteLine();
    }

    public void HideWord()
    {
        string[] words = text.Split(' ');
        Random rand = new Random();
        int index = rand.Next(words.Length);
        string wordToHide = words[index];
        hiddenWords.Add(new Word(wordToHide));
    }

    public bool AllWordsHidden()
    {
        string[] words = text.Split(' ');
        return hiddenWords.Count == words.Length;
    }

    private bool IsWordHidden(string word)
    {
        foreach (Word hiddenWord in hiddenWords)
        {
            if (hiddenWord.Text == word)
            {
                return true;
            }
        }
        return false;
    }
}
