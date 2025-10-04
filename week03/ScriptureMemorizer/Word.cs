using System;
// Word.cs
public class Word
{
    // Private variables (secret info only this class knows)
    private string _text;      // The actual word like "God"
    private bool _isHidden;    // Is it hidden? true or false
    
    // Constructor: This runs when you create a new Word
    public Word(string text)
    {
        _text = text;
        _isHidden = false;  // Start visible (not hidden)
    }
    
    // Method: Hide this word
    public void Hide()
    {
        _isHidden = true;
    }
    
    // Method: Check if hidden
    public bool IsHidden()
    {
        return _isHidden;
    }
    
    // Method: Get what to display (word or underscores)
    public string GetDisplayText()
    {
        if (_isHidden)
        {
            // If hidden, return underscores
            // "God" becomes "___" (3 underscores)
            return new string('_', _text.Length);
        }
        else
        {
            // If not hidden, return the actual word
            return _text;
        }
    }
}