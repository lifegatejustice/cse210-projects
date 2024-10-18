using System;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    public void Run()
    {
        DisplayStartingMessage();
        ShowCountDown(3); // Get ready countdown

        int secondsRemaining = _duration;  // Assuming _duration is defined in the base class

        while (secondsRemaining > 0)
        {
            Console.Write("\nBreathe in... ");
            ShowSpinner(5); // 5 seconds inhale
            Console.WriteLine("\nNow Breathe out... ");
            ShowSpinner(5); // 5 seconds exhale

            secondsRemaining -= 10;  // Subtract 10 seconds for each cycle (inhale + exhale)

            // Optionally show a pause or clear the screen between cycles
            Console.WriteLine("...");
            ShowSpinner(5); // Optional pause between cycles
            secondsRemaining -= 5;

            // Optionally clear the console for the next cycle
            // Console.Clear(); // Uncomment if you want to clear the console for each cycle
        }

        DisplayEndingMessage();
    }

    // Simulated spinner method (modify as per your spinner implementation)
    private void ShowSpinner(int seconds)
    {
        string[] spinner = { "/", "-", "\\", "|" }; // Spinner frames
        for (int i = 0; i < seconds * 4; i++) // 4 frames per second
        {
            Console.Write("\r" + spinner[i % 4]); // Spinner rotates
            System.Threading.Thread.Sleep(250); // Pause for 250 ms
        }
        Console.Write("\r "); // Clear the spinner after completion
    }
}
