using System;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    public void Run()
    {
        DisplayStartingMessage();
        ShowCountDown(3);

        int secondsRemaining = _duration;

        while (secondsRemaining > 0)
        {
            Console.Write("Breathe in...");
            ShowSpinner(5); // Pause for 5 seconds
            Console.WriteLine("Now Breathe out...");
            ShowSpinner(5); 
            secondsRemaining -= 5;

            Console.WriteLine("Breathe out...");
            ShowSpinner(5); // Pause for 5 seconds
            secondsRemaining -= 5;
        }

        DisplayEndingMessage();
    }
}
