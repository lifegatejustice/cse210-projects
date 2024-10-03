using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("John", 3, 16, 16);
        Scripture scripture = new Scripture(reference, "For God so loved the world");

        scripture.HideRandomWords(2);
        
        // Display the scripture with words visible
        Console.WriteLine(scripture.GetDisplayText());

        Console.WriteLine("Press Enter to continue or any other key to quit.");
        string input = Console.ReadLine();

        if (input == "") // Press Enter to continue
        {
            // Example: Reveal more hidden words or continue interaction
            Console.WriteLine("You pressed Enter. Continuing...");
        }
        else
        {
            Console.WriteLine("You pressed another key. Exiting.");
        }
    }
}