using System;

public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    // Set the duration for the activity
    public void SetDuration(int duration)
    {
        _duration = duration;
    }

    // Display a starting message
    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name} activity.");
        Console.WriteLine($"{_description}");
        Console.WriteLine($"Duration: {_duration} seconds.");
    }

    // Display an ending message
    public void DisplayEndingMessage()
    {
        Console.WriteLine($"Well done! You've completed the {_name} activity for {_duration} seconds.");
        ShowSpinner(3, "Pausing...");
    }

    // Display a countdown timer before starting the activity
   public void ShowCountDown(int seconds)
    {
        string[] spinner = { "/", "-", "\\", "|" }; // Animation frames
        for (int i = seconds; i > 0; i--)
        {
            foreach (string frame in spinner)
            {
                Console.Write("\rGet Ready" + frame);  // \r brings the cursor back to the beginning of the line
                System.Threading.Thread.Sleep(250); // Adjust speed of animation (250 ms per frame)
            }
        }
        Console.WriteLine();
    }

    // Show a simple spinner animation for the activity
    public void ShowSpinner(int seconds, string message)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"\r{message} {i}   ");  // Display the message and the countdown
            System.Threading.Thread.Sleep(1000);     // Wait for 1 second
        }
        Console.Write($"\r{message}       ");
        Console.WriteLine("                   "); // Clear the line after countdown
    }
}
