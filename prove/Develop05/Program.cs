using System;

class Program
{
    static void Main(string[] args)
    {
        Activity breathingActivity = new BreathingActivity();
        breathingActivity.SetDuration(10);
        breathingActivity.DisplayStartingMessage();
        ((BreathingActivity)breathingActivity).Run();

        Console.WriteLine();  // Separator

        Activity listingActivity = new ListingActivity();
        listingActivity.SetDuration(15);
        ((ListingActivity)listingActivity).Run();

        Console.WriteLine();  // Separator

        Activity reflectingActivity = new ReflectingActivity();
        reflectingActivity.SetDuration(12);
        ((ReflectingActivity)reflectingActivity).Run();
    }
}