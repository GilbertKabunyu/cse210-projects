class Reference
{
    private string referenceText;

    public Reference(string referenceText)
    {
        this.referenceText = referenceText;
    }

    public void DisplayReference()
    {
        Console.WriteLine(referenceText);
    }
}