public class EnhancedBreathingActivity : BreathingActivity
{
    protected override void RunActivity()
    {
        for (int i = 0; i < Duration; i += 4)
        {
            Console.Write("Breathe in...");
            for (int j = 0; j < 5; j++)
            {
                Console.Write(".");
                Thread.Sleep(400); // Gradually increase the delay
            }
            Console.WriteLine();

            Console.Write("Breathe out...");
            for (int j = 0; j < 5; j++)
            {
                Console.Write(".");
                Thread.Sleep(800); // Gradually decrease the delay
            }
            Console.WriteLine();
        }
    }
}
