using System;

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
                Console.WriteLine("1. 📝 Write");
                Console.WriteLine("2. 📄 Display");
                Console.WriteLine("3. 💾 Save");
                Console.WriteLine("4. 📁 Load");
                Console.WriteLine("5. 👋 Quit");
                Console.WriteLine("What would you like to do? ");

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
                        Console.Write("What is the file name: ");
                        string saveFileName = Console.ReadLine();
                        myJournal.SaveToFile(saveFileName);
                        break;

                    case "4":
                        Console.Write("Filename to load from: ");
                        string loadFileName = Console.ReadLine();
                        myJournal.LoadFromFile(loadFileName);
                        break;

                    case "5":
                        running = false;
                        Console.WriteLine("Exiting...");
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
