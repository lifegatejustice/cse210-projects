using System;
using System.Collections.Generic;

public class ListingActivity: Activity
{
    private List<string> _prompts = new List<string> { "Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?"};
    private int _count;

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

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return  _prompts[index];
    }

    public List<string> GetListFromUser()
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