using System;

class Program
{
    static void Main(string[] args)
    {
         Reference reference = new Reference("John", 3, 16);
        Scripture scripture = new Scripture(reference, "For God so loved the world");

        scripture.HideRandomWords(2);
        
        // Display the scripture with words visible
        Console.WriteLine(scripture.GetDisplayText());

        Console.WriteLine("Press Enter to continue or any other key to quit ");
    }
}