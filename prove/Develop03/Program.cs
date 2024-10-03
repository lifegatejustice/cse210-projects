using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("John", 3, 16, 16);
        Scripture scripture = new Scripture(reference, "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.");
        
        // Display the scripture with words visible
        Console.WriteLine(scripture.GetDisplayText());

        while (scripture.IsCompletelyHidden() == false)
        {
            // Wait for user to press Enter or any key
            string input = Console.ReadLine();
            
            if (input == "")
            {
                // Hide 1 random word each time Enter is pressed
                scripture.HideRandomWords(1);
                
                // Display the scripture after hiding a word
                Console.WriteLine(scripture.GetDisplayText());
                
                // Check if all words are hidden
                if (scripture.IsCompletelyHidden())
                {
                    Console.WriteLine("All words are now hidden. Program will exit.");
                    break;
                }
            }
            else
            {
                // Hide all words if any key is pressed other than Enter
            }
        }

    }
}