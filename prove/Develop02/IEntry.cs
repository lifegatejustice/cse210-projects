namespace JournalApp
{
    public interface IEntry
    {
        string Date { get; }
        string PromptText { get; }
        string EntryText { get; }
        void Display();
    }
}
