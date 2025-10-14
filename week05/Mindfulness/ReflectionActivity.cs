using System;

public class ReflectionActivity : Activity
{
     private List<string> _prompt = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectionActivity() : base("Reflecting Activity",
        "This activity will help you reflect on times in your life when you have shown strength and resilience. " +
        "This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
    }

    public override void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine("Consider The Following Prompt:");
        Console.WriteLine();
        DisplayPrompt(GetRandomPrompt());
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press Enter to continue.");
        Console.ReadLine();
        Console.Write("You may begin in:");
        ShowCountDown(5);
        
        Console.Clear();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            DisplayQuestion(GetRandomQuestion());
            ShowSpinner(15);
        }

        DisplayEndingMessage();

    }

    private string GetRandomPrompt()
    {
        Random _random = new Random();
        int index = _random.Next(_prompt.Count);
        return _prompt[index];
    }
   
    private string GetRandomQuestion()
    {
        Random _random = new Random();
        int index = _random.Next(_questions.Count);
        return _questions[index];
    }

    public void DisplayPrompt(string prompt)
    {
        Console.WriteLine($"-----------{prompt}-------------");
    }

    public void DisplayQuestion(string questions)
    {
        Console.WriteLine($"{questions}");
    }
}