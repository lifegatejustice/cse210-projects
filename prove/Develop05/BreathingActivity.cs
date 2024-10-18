using System;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    public void Run()
    {
        int secondsRemaining = _duration;

        while (secondsRemaining > 0)
        {
            
            Console.Write("Breathe in...");
            ShowSpinner(5, "Breathe in...");

            
            Console.Write("Now Breathe out...");
            ShowSpinner(5, "Now Breathe out...");

            
            secondsRemaining -= 10; 
        }

    }
}