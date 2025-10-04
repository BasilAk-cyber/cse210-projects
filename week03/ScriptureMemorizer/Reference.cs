using System;

// Reference.cs
public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;  // -1 means no ending verse
    
    // Constructor #1: Single verse like "John 3:16"
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = -1;  // No ending verse
    }
    
    // Constructor #2: Verse range like "Proverbs 3:5-6"
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;
    }
    
    // Method: Display the reference nicely
    public string GetDisplayText()
    {
        if (_endVerse == -1)
        {
            // Single verse: "John 3:16"
            return $"{_book} {_chapter}:{_verse}";
        }
        else
        {
            // Verse range: "Proverbs 3:5-6"
            return $"{_book} {_chapter}:{_verse}-{_endVerse}";
        }
    }
}