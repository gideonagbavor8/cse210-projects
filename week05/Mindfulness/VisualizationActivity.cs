public class VisualizationActivity : MindfulnessActivity
{
    public VisualizationActivity()
    {
        Name = "Visualization";
        Description = "This activity will help you relax by guiding you through a visualization exercise. Imagine yourself in a serene place or achieving something important to you.";
    }

    protected override void RunActivity()
    {
        Console.WriteLine("Close your eyes and take a deep breath. Imagine yourself in a peaceful place, like a beach, a forest, or a mountain top.");
        Thread.Sleep(5000); // Pause for 5 seconds

        Console.WriteLine("Visualize the details of this place: the sounds, the smells, the colors.");
        Thread.Sleep(Duration * 1000); // Pause for the duration of the activity
    }
}
