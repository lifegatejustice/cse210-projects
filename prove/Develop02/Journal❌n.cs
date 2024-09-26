// using System;
// using System.Collections.Generic;
// using System.IO;

// // Interface to abstract the behavior of the journal
// interface IJournal
// {
//     void WriteNewEntry();
//     void DisplayJournal();
//     void SaveJournalToFile(string fileName);
//     void LoadJournalFromFile(string fileName);
// }

// // Class representing a journal entry
// class Entry
// {
//     public string Prompt { get; set; }
//     public string Response { get; set; }
//     public DateTime Date { get; set; }

//     public Entry(string prompt, string response)
//     {
//         Prompt = prompt;
//         Response = response;
//         Date = DateTime.Now;
//     }

//     // Override ToString method to display the entry
//     public override string ToString()
//     {
//         return $"Date: {Date}\nPrompt: {Prompt}\nResponse: {Response}\n";
//     }
// }

// // Class representing the journal
// class Journal : IJournal
// {
//     private List<Entry> entries;
//     private List<string> prompts;

//     public Journal()
//     {
//         entries = new List<Entry>();
//         prompts = new List<string>
//         {
//             "What is one thing I learned today that I didn’t know before?",
//             "Who did I have the most meaningful conversation with today, and what did we talk about?",
//             "What was the most unexpected event that happened to me today?",
//             "Did I help anyone today, and how did it make me feel?",
//             "What new perspective did I gain from someone today?"
//         };
//     }

//     // Method to write a new entry
//     public void WriteNewEntry()
//     {
//         Random random = new Random();
//         string prompt = prompts[random.Next(prompts.Count)];

//         Console.WriteLine($"Prompt: {prompt}");
//         Console.Write("Enter your response: ");
//         string response = Console.ReadLine();

//         Entry entry = new Entry(prompt, response);
//         entries.Add(entry);
//         Console.WriteLine("Entry added successfully!");
//     }

//     // Method to display the journal
//      public void DisplayJournal()
//     {
//         foreach (Entry entry in entries)
//         {
//             Console.WriteLine(entry);
//         }
//     }

//     // Method to save the journal to a file
//     public void SaveJournalToFile(string fileName)
//     {
//         using (StreamWriter writer = new StreamWriter(fileName))
//         {
//             foreach (Entry entry in entries)
//             {
//                 writer.WriteLine(entry.Prompt);
//                 writer.WriteLine(entry.Response);
//                 writer.WriteLine(entry.Date);
//                 writer.WriteLine(); // Add an empty line between entries
//             }
//         }
//         Console.WriteLine("Journal saved successfully!");
//     }

//     // Method to load the journal from a file
//     public void LoadJournalFromFile(string fileName)
//     {
//         entries.Clear();
// //         (StreamReader reader = new StreamReader(fileName))
//         {
//             while (!reader.EndOfStream)
//             {
//                 string prompt = reader.ReadLine();
//                 string response = reader.ReadLine();
//                 DateTime date = DateTime.Parse(reader.ReadLine());
//                 reader.ReadLine(); // Read the empty line

//                 Entry entry = new Entry(prompt, response) { Date = date };
//                 entries.Add(entry);
//             }
//         }
//         Console.WriteLine("Journal loaded successfully!");
//     }
// }

