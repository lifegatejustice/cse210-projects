using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string> { "Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?" };

    public ListingActivity() : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
    }

    public void Run()
    {
        DisplayStartingMessage();
        ShowCountDown(3);

        string prompt = GetRandomPrompt();
        Console.WriteLine($"Prompt: {prompt}");

        List<string> userResponses = GetListFromUser();
        Console.WriteLine("You listed:");
        foreach (var item in userResponses)
        {
            Console.WriteLine(item);
        }

        DisplayEndingMessage();
    }

    private string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    private List<string> GetListFromUser()
    {
        List<string> list = new List<string>();
        Console.WriteLine("Enter your list items (type 'done' when finished):");

        string input;
        while ((input = Console.ReadLine()) != "done")
        {
            list.Add(input);
        }

        return list;
    }
}
