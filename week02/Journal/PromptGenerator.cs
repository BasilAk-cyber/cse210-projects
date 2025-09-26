using System;

public class PromptGenerator
{
    private List<string> _prompts;
    private Random _random;

    public PromptGenerator()
    {
        _random = new Random();
        _prompts = new List<string>()
        {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What made me smile today?",
        "What challenge did I overcome today?",
        "What am I most grateful for right now?",
        "What did I learn about myself today?",
        "How did I show kindness to someone today?",
        "What goal did I make progress on today?",
        "What surprised me most about today?",
        "If today had a theme song, what would it be and why?",
        "What would I tell my past self about today?",
        "What small victory should I celebrate from today?"
        };


    }

    public string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);
        return _prompts[index];
    }

}