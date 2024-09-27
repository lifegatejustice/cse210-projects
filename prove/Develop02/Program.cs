using System;




namespace JournalApp
{
    public interface IJournal
    {
        // Method to add a new entry
        void AddEntry(); 

        // Method to display all entries
        void DisplayAll(); 
         // Method to save entries to a file
        void SaveToFile(string fileName);
        // Method to load entries from a file
        void LoadFromFile(string fileName); 
    }
}
namespace JournalApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Journal myJournal = new Journal();
            bool running = true;

            while (running)
            {
                Console.WriteLine("Journal Application Menu:");
                Console.WriteLine("1. Add New Entry");
                Console.WriteLine("2. Display All Entries");
                Console.WriteLine("3. Save Journal to File");
                Console.WriteLine("4. Load Journal from File");
                Console.WriteLine("5. Quit");
                Console.WriteLine("Select an option (1-5):");

                string choice = Console.ReadLine();
                Console.WriteLine();

                switch (choice)
                {
                    case "1":
                        
                        myJournal.AddEntry();
                        break;

                    case "2":
                        Console.WriteLine("All Journal Entries:");
                        myJournal.DisplayAll();
                        break;

                    case "3":
                        Console.Write("Enter filename to save to: ");
                        string saveFileName = Console.ReadLine();
                        myJournal.SaveToFile(saveFileName);
                        break;

                    case "4":
                        Console.Write("Enter filename to load from: ");
                        string loadFileName = Console.ReadLine();
                        myJournal.LoadFromFile(loadFileName);
                        break;

                    case "5":
                        running = false;
                        Console.WriteLine("Exiting the application. Goodbye!");
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please select a valid option (1-5).");
                        break;
                }

                Console.WriteLine(); // Add an empty line for better readability
            }
        }
    }
}
