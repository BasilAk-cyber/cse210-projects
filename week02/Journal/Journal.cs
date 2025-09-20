using System;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    public void DisplayJournal()
    {
        foreach (Entry entry in _entries)
        {
            Console.WriteLine(entry);
            Console.WriteLine();
        }
    }

    public int EntryCount()
    {
        return _entries.Count;
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter OutputFile = new StreamWriter($"{filename}.txt"))
        {
            foreach(Entry entry in _entries)
            {
                OutputFile.WriteLine($"Date: {entry._date}");
                OutputFile.WriteLine($"Prompt: {entry._prompt}");
                OutputFile.WriteLine($"Response: {entry._response}\n");
                OutputFile.WriteLine();
            }
        }
    }
}