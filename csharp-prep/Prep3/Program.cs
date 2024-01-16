using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Prep3 World!");
        // a variable to store the user choice

        string playAgain = "yes";

        // how many time the user want to play
        while (playAgain == "yes")
        {
            Random random = new Random();
            int magicNumber = random.Next(1, 101);

            // variable to store the user guess
            int guess = 0;

            // variable to store the number
            int count = 0;

            // loops as the guess does not match the magic number
            while (guess != magicNumber)
            {
                //the user guess number
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());

                //the number of guess of user
                count++;

                // determine the user needs to guess high or low
                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guess it!");
                }
            }

            // notify the user how many guess they made
            Console.WriteLine($"You made {count} guesses.");

            // ask to play again
            Console.Write("Do you want to play again (yes/no) ");
            playAgain = Console.ReadLine();

        }

        // give thanks for playing the game
        Console.WriteLine("Thank you for playing!");
    }
}