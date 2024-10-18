using System;
using System.Collections.Generic;

public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string> { "Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless." };
    private List<string> _questions = new List<string> { "Why was this experience meaningful to you?", "Have you ever done anything like this before?", "How did you feel when it was complete?", "What could you learn from this experience that applies to other situations?" };

    public ReflectingActivity() : base("Reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
    }

    public void Run()
    {
        DisplayStartingMessage();
        ShowCountDown(3);

        string prompt = GetRandomPrompt();
        Console.WriteLine($"Prompt: {prompt}");

        int secondsRemaining = _duration;

        while (secondsRemaining > 0)
        {
            string question = GetRandomQuestion();
            Console.WriteLine($"Reflection: {question}");
            ShowSpinner(5); // Pauses for thinking time
            secondsRemaining -= 5;
        }

        DisplayEndingMessage();
    }

    private string GetRandomPrompt()
    {
        Random rnd = new Random();
        int index = rnd.Next(_prompts.Count);
        return _prompts[index];
    }

    private string GetRandomQuestion()
    {
        Random rnd = new Random();
        int index = rnd.Next(_questions.Count);
        return _questions[index];
    }
}
