// Author: Gideon Komla Agbavor 

using System;

class Program
{
    static void Main()
    {
        bool playAgain = true;

        while (playAgain)
        {
            Random random = new Random();

            // Step 1: Generate a random magic number
            int magicNumber = random.Next(1, 101); // Random number between 1 and 100

            Console.WriteLine("A magic number has been chosen between 1 and 100.");

            // Step 2: Initialize the guess and counter
            int guess = -1;  // Initialize to a number that can't be the magic number
            int guessCount = 0;

            // Step 3: Loop until the guess is correct
            while (guess != magicNumber)
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                guessCount++;

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
                    Console.WriteLine("You guessed it!");
                    Console.WriteLine($"It took you {guessCount} guesses.");
                }
            }

            // Ask if the user wants to play again
            Console.Write("Do you want to play again? (yes/no) ");
            playAgain = Console.ReadLine().ToLower() == "yes";
        }
    }
}
