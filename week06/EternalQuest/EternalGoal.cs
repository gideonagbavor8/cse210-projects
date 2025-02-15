public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
    {
        Name = name;
        Description = description;
        Points = points;
    }

    public override void RecordEvent()
    {
        Console.WriteLine($"{Name} logged! You earned {Points} points.");
    }

    public override bool IsComplete()
    {
        return false; // Eternal goals are never complete
    }

    public override string GetDetailsString()
    {
        return $"[ ] {Name} - {Description} (Points: {Points} each time)";
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal|{Name}|{Description}|{Points}";
    }
}
