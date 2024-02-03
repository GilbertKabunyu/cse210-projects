using System;

class Program
{
    static void Main(string[] args)
    {
        // Testing the classes
        MathAssignment mathAssignment = new MathAssignment("Samuel Bennett", "Multiplication", "7.3", "3-10, 20-21");
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());

        WritingAssignment writingAssignment = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInformation());
    }
}