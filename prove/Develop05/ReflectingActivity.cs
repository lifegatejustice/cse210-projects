using System;
using System.Collections.Generic;

public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you feel when it was complete?",
        "What could you learn from this experience that applies to other situations?"
    };

    private Random _random = new Random(); // Single instance of Random

    public ReflectingActivity() : base("Reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
    }

    public void Run()
    {
        DisplayStartingMessage();
        ShowCountDown(3); // Countdown before starting the activity

        string prompt = GetRandomPrompt();
        Console.WriteLine($"Prompt: {prompt}");

        int secondsRemaining = _duration;

        while (secondsRemaining > 0)
        {
            string question = GetRandomQuestion();
            Console.WriteLine($"Reflection: {question}");

            // Show countdown with thinking time
            ShowSpinner(5, "Thinking...");

            // Optionally, allow the user to type their thoughts
            Console.WriteLine("Type your thoughts (or press Enter to continue):");
            Console.ReadLine(); // Wait for user input

            secondsRemaining -= 5; // Decrease remaining time
        }

        DisplayEndingMessage();
    }

    private string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);
        return _prompts[index];
    }

    private string GetRandomQuestion()
    {
        int index = _random.Next(_questions.Count);
        return _questions[index];
    }
}
