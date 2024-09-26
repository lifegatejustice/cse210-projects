// class Program
// {
//     static void Main(string[] args)
//     {
//         IJournal journal = new Journal();

//         while (true)
//         {
//             Console.WriteLine("\nMenu:");
//             Console.WriteLine("1. Write");
//             Console.WriteLine("2. Display");
//             Console.WriteLine("3. Save");
//             Console.WriteLine("4. Load");
//             Console.WriteLine("5. Quit");
//             Console.Write("What would you like to do? ");
//             int choice = int.Parse(Console.ReadLine());

//             switch (choice)
//             {
//                 case 1:
//                     journal.WriteNewEntry();
//                     break;
//                 case 2:
//                     journal.DisplayJournal();
//                     break;
//                 case 3:
//                     Console.Write("What is the file name to save: ");
//                     string saveFileName = Console.ReadLine();
//                     journal.SaveJournalToFile(saveFileName);
//                     break;
//                 case 4:
//                     Console.Write("Enter the file name to load: ");
//                     string loadFileName = Console.ReadLine();
//                     journal.LoadJournalFromFile(loadFileName);
//                     break;
//                 case 5:
//                     Console.WriteLine("Exiting...");
//                     return;
//                 default:
//                     Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.");
//                     break;
//             }
//         }
//     }
// }