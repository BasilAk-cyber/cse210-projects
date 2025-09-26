using System;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    public void DisplayAll()
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
        using (StreamWriter OutputFile = new StreamWriter($"{filename}"))
        {
            foreach(Entry entry in _entries)
            {
                OutputFile.WriteLine($"Date: {entry._date} - Prompt: {entry._prompt} - Response: {entry._response}");
                OutputFile.WriteLine();
            }
        }
    }

    public void LoadFromFile(string filename)
    {
        Console.WriteLine("Reading File...");

        string[] lines = File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            if(!string.IsNullOrWhiteSpace(line))
            {
                if(line.StartsWith("Date: "))
                {
                    string content = line.Substring(6);

                    string[] parts = content.Split(new string[] { " - Prompt: ", " - Response: " }, StringSplitOptions.None);

                    if (parts.Length == 3)
                    {
                        Entry entry = new Entry(parts[1], parts[2], parts[0]);
                        /* {
                            _date = parts[0],
                            _prompt = parts[1],
                            _response = parts[2]
                        }; */
                        AddEntry(entry);
                    }
                }
            }
        }
        Console.WriteLine($"Journal loaded from {filename}");
        Console.WriteLine($"Loaded {_entries.Count} entries.");
        
    }
}