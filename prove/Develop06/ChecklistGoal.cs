using System;
using System.Collections;

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus)
        : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        _amountCompleted++;
        if (_amountCompleted >= _target)
        {
            Console.WriteLine($"Goal complete! You've earned {_points + _bonus} points for completing: {_shortName}");
        }
        else
        {
            Console.WriteLine($"You've earned {_points} points. {_target - _amountCompleted} more to complete: {_shortName}");
        }
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public override string GetDetailsString()
    {
        return $"[{(_amountCompleted >= _target ? "X" : " ")}] {_shortName} ({_description}) - Completed {_amountCompleted}/{_target} times";
    }

    public override string GetStringRepresentation()
{
    return $"Checklist,{_shortName},{_description},{_points},{_amountCompleted},{_target},{_bonus}";
}

}
