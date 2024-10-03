using System;

class Program
{
    static void Main(string[] args)
    {
         Reference reference = new Reference("John", 3, 16);
        Scripture scripture = new Scripture(reference, "For God so loved the world");
        
        // Display the scripture with words visible
        Console.WriteLine(scripture.GetDisplayText());
    }
}