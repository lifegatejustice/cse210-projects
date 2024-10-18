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
            // Breathe in for 5 seconds with countdown
            ShowSpinner(5, "Breathe in...");
            
            // Breathe out for 5 seconds with countdown
            ShowSpinner(5, "Now Breathe out...");

            // Decrease remaining time
            secondsRemaining -= 10;

            // Optional pause or rest between cycles
            if (secondsRemaining > 0)
            {
                Console.WriteLine("\nTake a short pause...");
                ShowSpinner(5, "Pausing..."); // 5-second pause between cycles
                secondsRemaining -= 5;
            }
        }

        DisplayEndingMessage();
    }
}