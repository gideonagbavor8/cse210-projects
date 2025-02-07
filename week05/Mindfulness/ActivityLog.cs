public class ActivityLog
{
    private Dictionary<string, int> log = new Dictionary<string, int>();

    public void LogActivity(string activityName)
    {
        if (!log.ContainsKey(activityName))
        {
            log[activityName] = 0;
        }
        log[activityName]++;
    }

    public void DisplayLog()
    {
        Console.WriteLine("Activity Log:");
        foreach (var entry in log)
        {
            Console.WriteLine($"{entry.Key}: {entry.Value} times");
        }
    }
}
