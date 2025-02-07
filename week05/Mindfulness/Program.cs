


public class Program
{
    public static void Main(string[] args)
    {
        ActivityLog activityLog = new ActivityLog();

        while (true)
        {
            Console.WriteLine("Choose an activity:");
            Console.WriteLine("1. Breathing");
            Console.WriteLine("2. Reflection");
            Console.WriteLine("3. Listing");
            Console.WriteLine("4. Visualization");
            Console.WriteLine("5. View Activity Log");
            Console.WriteLine("6. Exit");
            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());

            MindfulnessActivity activity = choice switch
            {
                1 => new EnhancedBreathingActivity(), // Use the enhanced breathing activity
                2 => new ReflectionActivity(),
                3 => new ListingActivity(),
                4 => new VisualizationActivity(),
                5 => null,
                6 => null,
                _ => null
            };

            if (activity == null)
            {
                if (choice == 5)
                {
                    activityLog.DisplayLog();
                }
                else
                {
                    break;
                }
            }
            else
            {
                activity.Start();
                activityLog.LogActivity(activity.Name);
            }
        }
    }
}
