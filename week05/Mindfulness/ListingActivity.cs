public class ListingActivity : MindfulnessActivity
{
    private string[] Prompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity()
    {
        Name = "Listing";
        Description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }

    protected override void RunActivity()
    {
        Random random = new Random();
        string prompt = Prompts[random.Next(Prompts.Length)];
        Console.WriteLine(prompt);
        Thread.Sleep(3000); // Pause for 3 seconds

        DateTime endTime = DateTime.Now.AddSeconds(Duration);
        int count = 0;
        while (DateTime.Now < endTime)
        {
            Console.WriteLine("List an item: ");
            Console.ReadLine(); // Accept input from the user
            count++;
        }
        Console.WriteLine($"You listed {count} items.");
    }
}
