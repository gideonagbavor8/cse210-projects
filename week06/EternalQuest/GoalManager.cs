using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("1. Display Player Info");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Create Goal");
            Console.WriteLine("4. Record Event");
            Console.WriteLine("5. Save Goals");
            Console.WriteLine("6. Load Goals");
            Console.WriteLine("7. Exit");
            Console.Write("Choose an option: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    DisplayPlayerInfo();
                    break;
                case 2:
                    ListGoalDetails();
                    break;
                case 3:
                    CreateGoal();
                    break;
                case 4:
                    RecordEvent();
                    break;
                case 5:
                    SaveGoals();
                    break;
                case 6:
                    LoadGoals();
                    break;
                case 7:
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Score: {_score}");
    }

    public void ListGoalNames()
    {
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.Name);
        }
    }

    public void ListGoalDetails()
    {
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    public void CreateGoal()
    {
        Console.Write("Enter goal type (1: Simple, 2: Eternal, 3: Checklist): ");
        int type;
        while (!int.TryParse(Console.ReadLine(), out type) || (type < 1 || type > 3))
        {
            Console.WriteLine("Invalid input. Please enter a number between 1 and 3.");
        }

        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();

        Console.Write("Enter goal description: ");
        string description = Console.ReadLine();

        Console.Write("Enter goal points: ");
        int points;
        while (!int.TryParse(Console.ReadLine(), out points))
        {
            Console.WriteLine("Invalid input. Please enter a valid number for points.");
        }

        switch (type)
        {
            case 1:
                _goals.Add(new SimpleGoal(name, description, points));
                break;
            case 2:
                _goals.Add(new EternalGoal(name, description, points));
                break;
            case 3:
                Console.Write("Enter target count: ");
                int targetCount = int.Parse(Console.ReadLine());
                Console.Write("Enter bonus points: ");
                int bonus = int.Parse(Console.ReadLine());
                _goals.Add(new ChecklistGoal(name, description, points, targetCount, bonus));
                break;
            default:
                Console.WriteLine("Invalid goal type.");
                break;
        }
    }

    public void RecordEvent()
    {
        ListGoalNames();
        Console.Write("Enter goal name to record event: ");
        string goalName = Console.ReadLine();

        foreach (var goal in _goals)
        {
            if (goal.Name == goalName)
            {
                goal.RecordEvent();
                _score += goal.Points;
                if (goal is ChecklistGoal checklistGoal && checklistGoal.IsComplete())
                {
                    _score += checklistGoal.Bonus;
                }
                return;
            }
        }

        Console.WriteLine("Goal not found.");
    }

    public void SaveGoals()
    {
        using (StreamWriter writer = new StreamWriter("goals.txt"))
        {
            writer.WriteLine(_score);
            foreach (var goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.WriteLine("Goals saved.");
    }

    public void LoadGoals()
    {
        if (File.Exists("goals.txt"))
        {
            using (StreamReader reader = new StreamReader("goals.txt"))
            {
                _score = int.Parse(reader.ReadLine());
                _goals.Clear();

                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] parts = line.Split('|');
                    string type = parts[0];
                    string name = parts[1];
                    string description = parts[2];
                    int points = int.Parse(parts[3]);

                    switch (type)
                    {
                        case "SimpleGoal":
                            bool isComplete = bool.Parse(parts[4]);
                            var simpleGoal = new SimpleGoal(name, description, points);
                            if (isComplete)
                            {
                                simpleGoal.RecordEvent();
                            }
                            _goals.Add(simpleGoal);
                            break;
                        case "EternalGoal":
                            _goals.Add(new EternalGoal(name, description, points));
                            break;
                        case "ChecklistGoal":
                            int currentCount = int.Parse(parts[4]);
                            int targetCount = int.Parse(parts[5]);
                            int bonus = int.Parse(parts[6]);
                            var checklistGoal = new ChecklistGoal(name, description, points, targetCount, bonus)
                            {
                                CurrentCount = currentCount
                            };
                            _goals.Add(checklistGoal);
                            break;
                        default:
                            Console.WriteLine("Unknown goal type.");
                            break;
                    }
                }
            }
            Console.WriteLine("Goals loaded.");
        }
        else
        {
            Console.WriteLine("No saved goals found.");
        }
    }
}
