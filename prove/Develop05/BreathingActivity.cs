using System;
using System.Collections;
using System.Collections.Generic;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
        
    }

    public void Run()
    {
        DisplayStartingMessage();
        ShowCountDown(3);
        ShowSpinner(_duration);
        DisplayEndingMessage();
    }


}