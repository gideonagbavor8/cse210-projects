
// Creativity and Exceeding Requirements
// Implemented Eternal Goals which can be logged repeatedly, earning points each time.

// Implemented Checklist Goals that require multiple completions with progress tracking and a completion bonus.

// Added user interaction through a console menu.

// Provided saving and loading of goals to/from a text file, ensuring persistence.

// User-Friendly Features: Added informative messages for user actions and goal status.



using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Eternal Quest Program!");

        GoalManager goalManager = new GoalManager();
        goalManager.Start();
    }
}
