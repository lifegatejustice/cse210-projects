using System;
using System.Collections.Generic;
using System.IO;

namespace JournalApp
{
    public class Journal
    {
        private List<Entry> _entries;
        private PromptGenerator _promptGenerator; // Prompt generator

        public Journal()
        {
            _entries = new List<Entry>();
            _promptGenerator = new PromptGenerator(); // Initialize PromptGenerator
        }

        // Method to write a new entry
        public void AddEntry()
        {
            // Step 1: Get and display the random prompt
            string prompt = _promptGenerator.GetRandomPrompt(); 
            Console.WriteLine($"Prompt: {prompt}");

            // Step 2: Allow the user to enter their response
            Console.Write("Enter your response: ");
            string response = Console.ReadLine();

            // Step 3: Create a new journal entry and add it to the list
            Entry entry = new Entry(prompt, response);
            _entries.Add(entry);

            // Step 4: Confirm the entry was added successfully
            Console.WriteLine("Entry added successfully!");
        }

        // Method to display all entries
        public void DisplayAll()
        {
            foreach (Entry entry in _entries)
            {
                entry.Display();
            }
        }

        // Method to save entries to a file
        public void SaveToFile(string fileName)
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                foreach (Entry entry in _entries)
                {
                    writer.WriteLine(entry.PromptText);
                    writer.WriteLine(entry.EntryText);
                    writer.WriteLine(entry.Date);
                    writer.WriteLine(); // Add an empty line between entries
                }
            }
            Console.WriteLine("Journal saved successfully!");
        }

        // Method to load entries from a file
        public void LoadFromFile(string fileName)
        {
            _entries.Clear();
            using (StreamReader reader = new StreamReader(fileName))
            {
                while (!reader.EndOfStream)
                {
                    string prompt = reader.ReadLine();
                    string response = reader.ReadLine();
                    string date = reader.ReadLine();
                    reader.ReadLine(); // Read the empty line

                    Entry entry = new Entry(prompt, response);
                    _entries.Add(entry);
                }
            }
            Console.WriteLine("Journal loaded successfully!");
        }
    }
}
