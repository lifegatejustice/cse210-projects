using System;
using System.Collections.Generic;
using System.IO;

namespace JournalApp
{
    public class Journal : IJournal
    {
        private List<Entry> _entries;
        private PromptGenerator _promptGenerator; // Add PromptGenerator instance

        public Journal()
        {
            _entries = new List<Entry>();
            _promptGenerator = new PromptGenerator(); // Initialize PromptGenerator
        }

        // Method to write a new entry
        public void AddEntry(string response)
        {
            string prompt = _promptGenerator.GetRandomPrompt(); // Get random prompt
            Entry entry = new Entry(prompt, response);
            _entries.Add(entry);
            Console.WriteLine("Entry added successfully!");
        }

        public void DisplayAll()
        {
            foreach (IEntry entry in entries)
            {
                entry.Display();
            }
        }

        public void SaveToFile(string fileName)
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                foreach (IEntry entry in entries)
                {
                    writer.WriteLine(entry.PromptText);
                    writer.WriteLine(entry.EntryText);
                    writer.WriteLine(entry.Date);
                    writer.WriteLine(); // Add an empty line between entries
                }
            }
            Console.WriteLine("Journal saved successfully!");
        }

        public void LoadFromFile(string fileName)
        {
            entries.Clear();
            using (StreamReader reader = new StreamReader(fileName))
            {
                while (!reader.EndOfStream)
                {
                    string prompt = reader.ReadLine();
                    string response = reader.ReadLine();
                    string date = reader.ReadLine();
                    reader.ReadLine(); // Read the empty line

                    Entry entry = new Entry(prompt, response);
                    Console.WriteLine(entry.Date);
                    entries.Add(entry);
                }
            }
            Console.WriteLine("Journal loaded successfully!");
        }
    }
}
