using System;
using System.Collections;

public class Swimming : Activity
{
    private int _laps;

    public Swimming(DateTime date, int minutes, int laps) : base(date, minutes)
    {
        _laps = laps;
    }

    public override double GetDistance() => _laps * 50 / 1000.0; // in kilometers

    public override double GetSpeed() => (GetDistance() / Minutes) * 60; // km/h

    public override double GetPace() => Minutes / GetDistance(); // min per km
}