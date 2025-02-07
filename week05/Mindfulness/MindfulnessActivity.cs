using System;
using System.Threading;

public abstract class MindfulnessActivity
{
    public string Name;
    protected string Description;
    protected int Duration;

    public void Start()
    {
        Console.WriteLine($"Starting the {Name} activity.");
        Console.WriteLine(Description);
        Console.Write("Enter the duration in seconds: ");
        Duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Prepare to begin...");
        Thread.Sleep(2000); // Pause for a few seconds

        RunActivity();

        Console.WriteLine("Well done! You've completed the activity.");
        Console.WriteLine($"Activity: {Name}, Duration: {Duration} seconds.");
        Thread.Sleep(2000); // Pause before finishing
    }

    protected abstract void RunActivity();
}
