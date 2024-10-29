using System;
using System.Collections;

public class Cycling : Activity
{
    private double _distance; // in miles

    public Cycling(DateTime date, int minutes, double distance) : base(date, minutes)
    {
        _distance = distance;
    }

    public override double GetDistance() => _distance;

    public override double GetSpeed() => (_distance / Minutes) * 60; // mph

    public override double GetPace() => Minutes / _distance; // min per mile
}