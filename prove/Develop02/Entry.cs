using System;

namespace JournalApp
{
    public class Entry : IEntry
    {
        public string Date { get; private set; }
        public string PromptText { get; private set; }
        public string EntryText { get; private set; }

        public Entry(string promptText, string entryText)
        {
            PromptText = promptText;
            EntryText = entryText;
            Date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        public void Display()
        {
            Console.WriteLine($"Date: {Date}\nPrompt: {PromptText}\nResponse: {EntryText}\n");
        }
    }
}
