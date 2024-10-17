using System;
using System.Collections;

public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine("Menu Options");
        Console.WriteLine(" 1. Start breathing activity");
        Console.WriteLine(" 2. Start reflecting activity");
        Console.WriteLine(" 1. Start listing activity");
        Console.WriteLine(" 1. Quit");
        Console.ReadLine();
        Console.WriteLine("Select a choice from the menu: ");
    }
}