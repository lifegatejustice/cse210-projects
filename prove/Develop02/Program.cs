class Program
{
    static void Main(string[] args)
    {
        IJournal journal = new Journal();

        while (true)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    journal.WriteNewEntry();
                    break;
                case 2:
                    journal.DisplayJournal();
                    break;
                case 3:
                    Console.Write("Enter the file name to save: ");
                    string saveFileName = Console.ReadLine();
                    journal.SaveJournalToFile(saveFileName);
                    break;
                case 4:
                    Console.Write("Enter the file name to load: ");
                    string loadFileName = Console.ReadLine();
                    journal.LoadJournalFromFile(loadFileName);
                    break;
                case 5:
                    Console.WriteLine("Exiting...");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.");
                    break;
            }
        }
    }
}