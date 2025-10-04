using System;

// Scripture.cs
using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;  // A list is like a shopping cart of Word objects
    
    // Constructor: Create a scripture
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        
        // Split the text into words
        // "For God so" becomes ["For", "God", "so"]
        string[] wordArray = text.Split(' ');
        
        // Create a Word object for each word
        foreach (string word in wordArray)
        {
            _words.Add(new Word(word));
        }
    }
    
    // Method: Hide some random words
    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        int hiddenCount = 0;
        
        // Keep going until we hide enough words
        while (hiddenCount < numberToHide)
        {
            // Pick a random index (position in the list)
            int index = random.Next(_words.Count);
            
            // Only hide if not already hidden
            if (!_words[index].IsHidden())
            {
                _words[index].Hide();
                hiddenCount++;
            }
            
            // Safety check: if all words are hidden, stop trying
            if (IsCompletelyHidden())
            {
                break;
            }
        }
    }
    
    // Method: Get the full display text
    public string GetDisplayText()
    {
        // Start with the reference
        string result = _reference.GetDisplayText() + " ";
        
        // Add each word (visible or hidden)
        foreach (Word word in _words)
        {
            result += word.GetDisplayText() + " ";
        }
        
        return result.Trim();  // Remove extra space at end
    }
    
    // Method: Check if all words are hidden
    public bool IsCompletelyHidden()
    {
        // Loop through all words
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;  // Found one that's not hidden!
            }
        }
        return true;  // All words are hidden
    }
}