using System;
using System.Collections.Generic;

// Base class
public abstract class Activity
{
    private DateTime _date;
    private int _minutes;

    public Activity(DateTime date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    public DateTime Date => _date;
    public int Minutes => _minutes;

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual string GetSummary()
    {
        return $"{_date:dd MMM yyyy} {GetType().Name} ({_minutes} min) - Distance: {GetDistance()} " +
               $"{(GetType().Name == "Swimming" ? "meters" : "miles")}, Speed: {GetSpeed()} " +
               $"{(GetType().Name == "Swimming" ? "m/s" : "mph")}, Pace: {GetPace()} min per " +
               $"{(GetType().Name == "Swimming" ? "lap" : "mile")}";
    }
}