public class ChecklistGoal : Goal
{
    private int _targetCount;
    private int _currentCount;
    private int _bonus;

    public int TargetCount
    {
        get { return _targetCount; }
        set { _targetCount = value; }
    }

    public int CurrentCount
    {
        get { return _currentCount; }
        set { _currentCount = value; }
    }

    public int Bonus
    {
        get { return _bonus; }
        set { _bonus = value; }
    }

    public ChecklistGoal(string name, string description, int points, int targetCount, int bonus)
    {
        Name = name;
        Description = description;
        Points = points;
        _targetCount = targetCount;
        _bonus = bonus;
        _currentCount = 0;
    }

    public override void RecordEvent()
    {
        if (_currentCount < _targetCount)
        {
            _currentCount++;
            Console.WriteLine($"{Name} progress: {_currentCount}/{_targetCount} completions. You earned {Points} points.");
            if (_currentCount >= _targetCount)
            {
                Console.WriteLine($"Congratulations! You completed {Name} and earned a bonus of {Bonus} points.");
            }
        }
        else
        {
            Console.WriteLine($"{Name} is already completed.");
        }
    }

    public override bool IsComplete()
    {
        return _currentCount >= _targetCount;
    }

    public override string GetDetailsString()
    {
        return $"{(IsComplete() ? "[X]" : "[ ]")} {Name} - {Description} (Points: {Points}, Bonus: {Bonus}, Progress: {_currentCount}/{_targetCount})";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal|{Name}|{Description}|{Points}|{_currentCount}|{_targetCount}|{_bonus}";
    }
}
