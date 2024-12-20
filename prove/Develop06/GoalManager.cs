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
        Console.WriteLine(" -----------------------");
        Console.WriteLine("--------WELCOME TO ETERNAL QUEST----------");
        // Display the current score automatically at the top of the menu
        Console.WriteLine($"\nYou have: {_score} points");
        Console.WriteLine("Menu Options!");
        Console.WriteLine("1. Create Goal");
        Console.WriteLine("2. List Goals");
        Console.WriteLine("3. Save Goals");
        Console.WriteLine("4. Load Goals");
        Console.WriteLine("5. Record Event"); // Moved Record Event here
        Console.WriteLine("6. Exit");
        Console.WriteLine("Select choice from the Menu");

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
                SaveGoals();
                break;
            case "4":
                LoadGoals();
                break;
            case "5":
                RecordEvent();
                break;
            case "6":
                return;
            default:
                Console.WriteLine("Invalid choice, please try again.");
                break;
        }
    }
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
    Console.WriteLine("The type of Goals are: ");
    Console.WriteLine("1. Simple Goal");
    Console.WriteLine("2. Eternal Goal");
    Console.WriteLine("3. Checklist Goal");
    Console.WriteLine("What type of Goal would you like to create?");

    
    string goalType = Console.ReadLine();

    Console.WriteLine("What is the name of your goal?");
    string name = Console.ReadLine();

    Console.WriteLine("What is the short description of it?");
    string description = Console.ReadLine();

    Console.WriteLine("What is the amount of points associated with this goal?");
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
            Console.WriteLine("How many times does this goal need to accomplished for a bonus?");
            int target = int.Parse(Console.ReadLine());

            Console.WriteLine("What is the bonus for completing the goal that many times? ");
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
        Console.WriteLine("Which Goal did you accomplish? ");
        int index = int.Parse(Console.ReadLine()) - 1;

        if (index >= 0 && index < _goals.Count)
        {
            _goals[index].RecordEvent();
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
                string[] parts = line.Split(',');
                string goalType = parts[0];
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
                    Console.WriteLine("  ");
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
