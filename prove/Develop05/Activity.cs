using System;
using System.Collections;

public class Activity
{
    private string _name;
    private string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;

    }

    public void SetDuration(int duration)
    {
        _duration = duration;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name} activity.");
        Console.WriteLine($" {_description}");
        Console.WriteLine($"Duration: {_duration} seconds.");

    }

    public void DisplayEndingMessage()
    {
         Console.WriteLine($" Well done! You have completed the {_name} activity.");

    }

    public void ShowSpinner(int seconds)
    {
        Console.WriteLine("Spinner animation for activity in progress...");
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(".");
            System.Threading.Thread.Sleep(1000); // 1-second delay
        }
        Console.WriteLine();

    }

    public void ShowCountDown(int seconds)
    {
        Console.WriteLine("Countdown starting...");
        for (int i = seconds; i > 0; i--)
        {
            Console.WriteLine(i);
            System.Threading.Thread.Sleep(1000); // 1-second delay
        }
        Console.WriteLine("Go!");
    }
}