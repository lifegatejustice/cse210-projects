class Program
{
    static void Main(string[] args)
    {
        // List of scriptures with their references
        List<Scripture> scriptures = new List<Scripture>
        {
            new Scripture(new Reference("John", 3, 16, 16), "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life."),
            new Scripture(new Reference("Proverbs", 3, 5, 6), "Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight."),
            new Scripture(new Reference("Psalm", 23, 1, 4), "The Lord is my shepherd, I lack nothing. He makes me lie down in green pastures, he leads me beside quiet waters, he refreshes my soul."),
            new Scripture(new Reference("Philippians", 4, 13, 13), "I can do all this through him who gives me strength."),
            new Scripture(new Reference("Isaiah", 41, 10, 10), "So do not fear, for I am with you; do not be dismayed, for I am your God. I will strengthen you and help you; I will uphold you with my righteous right hand."),
            new Scripture(new Reference("Romans", 8, 28, 28), "And we know that in all things God works for the good of those who love him, who have been called according to his purpose."),
            new Scripture(new Reference("Matthew", 6, 33, 34), "But seek first his kingdom and his righteousness, and all these things will be given to you as well. Therefore do not worry about tomorrow, for tomorrow will worry about itself."),
            new Scripture(new Reference("Jeremiah", 29, 11, 11), "For I know the plans I have for you, declares the Lord, plans to prosper you and not to harm you, plans to give you hope and a future."),
            new Scripture(new Reference("Hebrews", 11, 1, 1), "Now faith is confidence in what we hope for and assurance about what we do not see."),
            new Scripture(new Reference("James", 1, 5, 5), "If any of you lacks wisdom, you should ask God, who gives generously to all without finding fault, and it will be given to you.")
        };

        int currentScriptureIndex = 0;
        Scripture currentScripture = scriptures[currentScriptureIndex];

        // Display the first scripture initially with no hidden words
        Console.WriteLine(currentScripture.GetDisplayText());

        // Prompt user to press Enter to hide words or type 'quit' to exit
        Console.WriteLine("Press Enter to hide random words, type 'next' to switch scriptures, or type 'quit' to exit.");

        while (true)
        {
            string input = Console.ReadLine();

            if (input == "") // If Enter is pressed, hide a word in the current scripture
            {
                currentScripture.HideRandomWords(1);
                Console.Clear();
                Console.WriteLine(currentScripture.GetDisplayText());

                // Check if all words are hidden in the current scripture
                if (currentScripture.IsCompletelyHidden())
                {
                    Console.WriteLine("All words are now hidden in this scripture.");
                }
            }
            else if (input.ToLower() == "next") // Switch to the next scripture
            {
                currentScriptureIndex = (currentScriptureIndex + 1) % scriptures.Count; // Cycle through scriptures
                currentScripture = scriptures[currentScriptureIndex];
                Console.Clear();
                Console.WriteLine(currentScripture.GetDisplayText());
            }
            else if (input.ToLower() == "quit") // Exit the program
            {
                Console.WriteLine("Exiting the program...");
                break;
            }
        }
    }
}