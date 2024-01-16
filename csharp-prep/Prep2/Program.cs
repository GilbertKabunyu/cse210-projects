using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage? ");
        string answer = Console.ReadLine();
        int percentage = int.Parse(answer);
       
       // a variable to store the letter
       string letter = "";

       // a variable to store a sign
       string sign = "";

       if (percentage >= 90)
       {
            letter = "A";
       }
       else if (percentage >= 80)
       {
            letter = "B";
       }
       else if (percentage >= 70)
        {
            letter = "C";
        }
       else if (percentage >= 60)
       {
            letter = "D";
       }
       else 
       {
            letter = "F";
       }
       // signs variables 
       if (letter == "A" && percentage <97)
       {
            sign = "-";
       }
       else if (letter == "F" && percentage >= 57)
       {
         sign = "";
       }
       else if (percentage % 10 < 3)
       {
            sign = "-";
       }
       else
       {
            sign = "";
       }
       // print the letter grade and sign
       Console.WriteLine($"Your letter grade is {letter} {sign}.");
       
       // pass or not the test codes
       if (percentage >= 70)
       {
            Console.WriteLine ("Congralution, you have passed the test.");
       }
       else
       {
            Console.WriteLine ("Sorry, you did not pass the test. Best luck next time.");
       }
    }
}