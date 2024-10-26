using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public void Start()
    {
        while (true)
        {
            Console.WriteLine("Welcome to Eternal Quest!");
            Console.WriteLine("1. Create a new goal");
            Console.WriteLine("2. List all goals");
            Console.WriteLine("3. Record an event");
            Console.WriteLine("4. View score");
            Console.WriteLine("5. Save goals");
            Console.WriteLine("6. Load goals");
            Console.WriteLine("7. Exit");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateGoal();
                    break;
                case "2":
                    ListGoalNames();
                    break;
                case "3":
                    RecordEvent();
                    break;
                case "4":
                    DisplayPlayerInfo();
                    break;
                case "5":
                    SaveGoals();
                    break;
                case "6":
                    LoadGoals();
                    break;
                case "7":
                    return;
                default:
                    Console.WriteLine("Invalid choice, please try again.");
                    break;
            }
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Current Score: {_score}");
    }

    public void ListGoalNames()
    {
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("Enter goal type (1: Simple, 2: Eternal, 3: Checklist):");
        string goalType = Console.ReadLine();

        Console.WriteLine("Enter the goal name:");
        string name = Console.ReadLine();

        Console.WriteLine("Enter the goal description:");
        string description = Console.ReadLine();

        Console.WriteLine("Enter the goal points:");
        int points = int.Parse(Console.ReadLine());

        Goal newGoal = null;

        switch (goalType)
        {
            case "1":
                newGoal = new SimpleGoal(name, description, points);
                break;
            case "2":
                newGoal = new EternalGoal(name, description, points);
                break;
            case "3":
                Console.WriteLine("Enter target amount:");
                int target = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter bonus points for completing the checklist:");
                int bonus = int.Parse(Console.ReadLine());
                newGoal = new ChecklistGoal(name, description, points, target, bonus);
                break;
            default:
                Console.WriteLine("Invalid goal type");
                return;
        }

        _goals.Add(newGoal);
        Console.WriteLine("Goal created successfully!");
    }

    public void RecordEvent()
    {
        ListGoalNames();
        Console.WriteLine("Enter the number of the goal to record an event for:");
        int index = int.Parse(Console.ReadLine()) - 1;

        if (index >= 0 && index < _goals.Count)
        {
            _goals[index].RecordEvent();
            // Optionally, update the player's score after recording an event
            _score += _goals[index].Points;
        }
        else
        {
            Console.WriteLine("Invalid goal number.");
        }
    }

    public void SaveGoals()
    {
        Console.WriteLine("Enter the filename to save goals (e.g., goals.txt):");
        string filename = Console.ReadLine();

        using (StreamWriter file = new StreamWriter(filename))
        {
            foreach (Goal goal in _goals)
            {
                file.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.WriteLine($"Goals saved to {filename}!");
    }

    public void LoadGoals()
{
    Console.WriteLine("Enter the filename to load goals from (e.g., goals.txt):");
    string filename = Console.ReadLine();

    if (File.Exists(filename))
    {
        _goals.Clear();
        string[] lines = File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            // Debug output for each line
            Console.WriteLine("Loading line: " + line);

            // Deserialize the goal based on its string representation
            string[] parts = line.Split(',');
            string goalType = parts[0]; // Identify the type of goal
            Goal loadedGoal = null;

            if (goalType == "Simple")
            {
                loadedGoal = new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]));
            }
            else if (goalType == "Eternal")
            {
                loadedGoal = new EternalGoal(parts[1], parts[2], int.Parse(parts[3]));
            }
            else if (goalType == "Checklist")
            {
                loadedGoal = new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]));
            }

            if (loadedGoal != null)
            {
                _goals.Add(loadedGoal);
                // Debug output for each loaded goal
                Console.WriteLine("Goal loaded: " + loadedGoal.GetDetailsString());
            }
        }
        Console.WriteLine("Goals loaded!");
    }
    else
    {
        Console.WriteLine("No saved goals found.");
    }
}

}
